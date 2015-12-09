/* Truck queue simulation */

#include <fstream>
#include <iomanip>
#include <iostream>
#include <memory>
#include <queue>
#include <sstream>
#include <vector>
#include <random>


namespace mytime {
	class Time {
	public:
		Time(long h, long m, long s = 0) : sec_{ h * 3600 + m * 60 + s } {}
		explicit Time(long s = 0) : sec_{ s } {}
		explicit Time(const std::string& str); // "hhh:mm:ss"
		void set(long s = 0, long m = 0, long h = 0) { sec_ = h * 3600 + m * 60 + s; }
		friend bool operator<(const Time& a, const Time& b) {
			return a.sec_ < b.sec_;
		}
		Time& operator+=(const Time& b) {
			sec_ += b.sec_;
			return *this;
		}
		Time& operator-=(const Time& b) {
			sec_ -= b.sec_;
			return *this;
		}
		Time& operator*=(int i) {
			sec_ *= i;
			return *this;
		}
		Time& operator/=(int i) {
			sec_ /= i;
			return *this;
		}

		std::string str() const {
			std::ostringstream os; // #include <sstream> <iomanip>
			os << sec_ / 3600 << ":"
				<< std::setfill('0') << std::setw(2) << (sec_ % 3600) / 60 << ":"
				<< std::setw(2) << sec_ % 60;
			return os.str();
		}

	private:
		long sec_{};
	};

	Time::Time(const std::string& str) { // "hhh:mm:ss"
		long s{}, m{}, h{};
		std::istringstream is{ str };
		is >> h;
		if (is && is.get() == ':') {
			is >> m;
			if (is && is.get() == ':')
				is >> s;
		}
		sec_ = h * 3600 + m * 60 + s;
	}
	bool operator<=(const Time& a, const Time& b) {
		return !(b < a);
	}
	bool operator>(const Time& a, const Time& b) {
		return b < a;
	}
	bool operator>=(const Time& a, const Time& b) {
		return !(a < b);
	}
	bool operator==(const Time& a, const Time& b) {
		return !(a < b) && !(b < a);
	}
	bool operator!=(const Time& a, const Time& b) {
		return !(a == b);
	}
	Time operator+(Time a, const Time& b) {
		return a += b;
	}
	Time operator-(Time a, const Time& b) {
		return a -= b;
	}
	Time operator*(Time a, int i) {
		return a *= i;
	}
	Time operator*(int i, Time a) {
		return a *= i;
	}
	Time operator/(Time a, int i) {
		return a /= i;
	}
}

using namespace mytime;

class Truck;
class Processing_unit;
struct SimilulationData;

std::ofstream out("output.txt");

////////// events //////////
class Event {
public:
	explicit Event(Time time) : time_{ time } {}
	virtual ~Event() {}
	virtual void run_task() = 0;
	void print_status(SimilulationData& sd);
	friend bool operator>(const Event& a, const Event& b) {
		return a.time_ > b.time_;
	}
protected:
	Time time_;
};

template <class Ptr>
struct greater_ptr {
	bool operator()(const Ptr& p1, const Ptr& p2) const {
		return (*p1) > (*p2);
	}
};

using P_event = std::shared_ptr<Event>;
using Event_queue = std::priority_queue<P_event, std::vector<P_event>, greater_ptr<P_event>>;
using Processing_units = std::vector<std::unique_ptr<Processing_unit>>;
using Truck_queue = std::queue<std::shared_ptr<Truck>>;




class Arrival final : public Event {
public:
	Arrival(const Time& t, std::shared_ptr<Truck>& tr) : Event{ t }, p_truck_{ tr } {}
	//void set_id(){ p_truck_->set_no(); }
	void run_task() override;
	void set(SimilulationData& sd) { p_sd_ = &sd; }
private:
	std::shared_ptr<Truck> p_truck_;
	SimilulationData* p_sd_;
};

class Completed final : public Event {
public:
	Completed(const Time& t, Processing_unit& pu) : Event{ t }, p_processing_unit_{ &pu } {}
	void run_task() override;
	void set(SimilulationData& sd) { p_sd_ = &sd; }
private:
	SimilulationData* p_sd_;
	Processing_unit* p_processing_unit_;
};

class Truck {
public:
	Truck(const Time& t) : time_{ t }, no_{ ++current_no_ } {}
	int id() const { return id_; }
	void set_no(){ id_ = ++make_no_; }
	const Time& arrival_time() const { return time_; }
private:
	static int current_no_;
	static int make_no_;
	Time time_;
	int no_;
	int id_;
};

int Truck::current_no_{};
int Truck::make_no_{};

class Processing_unit {
public:
	bool is_free() const { return !p_truck_; }
	void add(std::shared_ptr<Truck>& p) { p_truck_ = p; }
	std::shared_ptr<Truck> remove() {
		std::shared_ptr<Truck> r = p_truck_;
		p_truck_.reset();
		return r;
	}
	int truck_id() const { return p_truck_->id(); }
private:
	std::shared_ptr<Truck> p_truck_;
};

struct SimilulationData {
	Event_queue event_queue;
	Processing_units pro_units;
	Truck_queue truck_queue;
	Time processing_length;
	Time max_time;
	Time min_time;
	Time avg_time;
	int truck_total;
};

void Arrival::run_task() { // uses Truck
	p_truck_->set_no();
	std::cout << time_.str() << ": arrival of truck no " << std::setw(3) << p_truck_->id() << "\t\t\t";
	out << time_.str() << ": arrival of truck no " << std::setw(3) << p_truck_->id() << "\t\t\t";
	for (auto& p : p_sd_->pro_units) {

		if (p->is_free()) {
			p->add(p_truck_);
			auto pe = std::make_shared<Completed>(time_ + p_sd_->processing_length, *p);
			p_sd_->event_queue.emplace(pe);
			pe->set(*p_sd_);
			print_status(*p_sd_);

			return;
		}
	}
	p_sd_->truck_queue.emplace(p_truck_);
	print_status(*p_sd_);

}

void Completed::run_task() {
	auto p_truck = p_processing_unit_->remove();
	auto completion_time = time_ - p_truck->arrival_time();
	if (completion_time > p_sd_->max_time){
		p_sd_->max_time = completion_time;
	}
	if (completion_time < p_sd_->min_time){
		p_sd_->min_time = completion_time;
	}

	std::cout << time_.str() << ": completion of truck no "
		<< std::setw(3) << p_truck->id() << " after " << completion_time.str() << "\t";
	out << time_.str() << ": completion of truck no "
		<< std::setw(3) << p_truck->id() << " after " << completion_time.str() << "\t";
	if (!p_sd_->truck_queue.empty()) {
		p_processing_unit_->add(p_sd_->truck_queue.front());
		p_sd_->truck_queue.pop();
		auto pe = std::make_shared<Completed>(time_ + p_sd_->processing_length, *p_processing_unit_);
		p_sd_->event_queue.emplace(pe);
		pe->set(*p_sd_);
	}
	p_sd_->truck_total++;
	p_sd_->avg_time += completion_time;
	print_status(*p_sd_);
}

void Event::print_status(SimilulationData& sd) {
	std::cout << "Status: processing: ";

	out << "Status: processing: ";
	for (auto& p : sd.pro_units) {
		if (!p->is_free()){
			std::cout << p->truck_id() << ", ";
			out << p->truck_id() << ", ";
		}
	}
	std::cout << "queue: " << sd.truck_queue.size() << "\n";

	out << "queue: " << sd.truck_queue.size() << "\n";
}

void skip_heading(std::istream& is, char sentinel) {
	while (is) {
		if (is.get() == sentinel) return;
	}
}

int main() {
	SimilulationData sd;
	sd.truck_total = 0;
	sd.min_time = Time(0, 30);
	std::ifstream in("times.txt");
	skip_heading(in, ':');
	int no_processing_units;
	in >> no_processing_units;
	if (no_processing_units < 1) no_processing_units = 1;
	skip_heading(in, ':');
	int processing_min;
	in >> processing_min;
	sd.processing_length = Time(0, processing_min);
	for (int i = 0; i < no_processing_units; ++i)
		sd.pro_units.emplace_back(std::make_unique<Processing_unit>());
	// read input file
	/*skip_heading(in, ':');
	std::string str;
	while (in && !in.eof()) {
	in >> str;
	if (in.fail() || str.length() == 0) break;
	Time arrival_time{ str };
	auto pe = std::make_shared<Arrival>(arrival_time, std::make_shared<Truck>(arrival_time));
	sd.event_queue.emplace(pe);
	pe->set(sd);
	}*/
	// run events

	int count = 0;
	int number_of_trucks(200);
	Time arrival_time(0);

	std::mt19937 mt_rand(time(0));
	std::uniform_int_distribution<int> range(0, 3600 * 13);

	while (count < number_of_trucks) {
		arrival_time = Time(range(mt_rand));
		std::shared_ptr<Arrival> pe = std::make_shared<Arrival>(arrival_time, std::make_shared<Truck>(arrival_time));

		sd.event_queue.emplace(pe);
		pe->set(sd);
		count++;
	}


	while (!sd.event_queue.empty()) {
		sd.event_queue.top()->run_task();
		sd.event_queue.pop();
	}
	sd.max_time -= Time(0, 10);
	sd.min_time -= Time(0, 10);
	


	std::cout << "Max time is " << sd.max_time.str() << "\n";
	std::cout << "Min time is " << sd.min_time.str() << "\n";
	std::cout << "Total trucks is " << sd.truck_total << "\n";

	out << "Max time is " << sd.max_time.str() << "\n";
	out << "Min time is " << sd.min_time.str() << "\n";
	out << "Total trucks is " << sd.truck_total << "\n";

	sd.avg_time /= sd.truck_total;
	sd.avg_time -= Time(0, 10);

	std::cout << "Avg time is " << sd.avg_time.str() << "\n";
	out << "Avg time is " << sd.avg_time.str() << "\n";

	system("pause");
}