#pragma once

#include <string>
#include <fstream>
#include <iomanip>
#include <iostream>
#include <memory>
#include <queue>
#include <sstream>
#include <vector>
#include "graphic_classes.h"

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
        std::wstring wstr() const {
            std::wostringstream os; // #include <sstream> <iomanip>
            os << sec_ / 3600 << L":"
                << std::setfill(L'0') << std::setw(2) << (sec_ % 3600) / 60 << L":"
                << std::setw(2) << sec_ % 60;
            return os.str();
        }

    private:
        long sec_{};
    };

    inline Time::Time(const std::string& str) { // "hhh:mm:ss"
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
    inline bool operator<=(const Time& a, const Time& b) {
        return !(b < a);
    }
    inline bool operator>(const Time& a, const Time& b) {
        return b < a;
    }
    inline bool operator>=(const Time& a, const Time& b) {
        return !(a < b);
    }
    inline bool operator==(const Time& a, const Time& b) {
        return !(a < b) && !(b < a);
    }
    inline bool operator!=(const Time& a, const Time& b) {
        return !(a == b);
    }
    inline Time operator+(Time a, const Time& b) {
        return a += b;
    }
    inline Time operator-(Time a, const Time& b) {
        return a -= b;
    }
    inline Time operator*(Time a, int i) {
        return a *= i;
    }
    inline Time operator*(int i, Time a) {
        return a *= i;
    }
    inline Time operator/(Time a, int i) {
        return a /= i;
    }
}

using namespace mytime;

class Truck;
class Processing_unit;
struct SimilulationData;

////////// events //////////
class Event {
public:
    explicit Event(mytime::Time time) : time_{ time } {}
    virtual ~Event() {}
    virtual void run_task(CClientDC&) = 0;
    void print_status(SimilulationData& sd);
    friend bool operator>(const Event& a, const Event& b) {
        return a.time_ > b.time_;
    }
    mytime::Time time() const { return time_;  }
protected:
    mytime::Time time_;
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
    Arrival(const mytime::Time& t, std::shared_ptr<Truck>& tr) : Event{ t }, p_truck_{tr} {}
    void run_task(CClientDC& dc) override;
    void set(SimilulationData& sd) { p_sd_ = &sd; }
private:
    std::shared_ptr<Truck> p_truck_;
    SimilulationData* p_sd_;
};

class Completed final : public Event {
public:
    Completed(const mytime::Time& t, Processing_unit& pu) : Event{ t }, p_processing_unit_{&pu} {}
    void run_task(CClientDC& dc) override;
    void set(SimilulationData& sd) { p_sd_ = &sd; }
private:
    SimilulationData* p_sd_;
    Processing_unit* p_processing_unit_;
};

class Truck {
public:
    Truck(const mytime::Time& t) : time_{ t }, no_{ ++current_no_ } {}
    int id() const { return no_;  }
    const mytime::Time& arrival_time() const { return time_; }
    Shape& getGraphic() { return graphic_; }
private:
    static int current_no_;
    mytime::Time time_;
    int no_;
    Dot graphic_;
};

class Processing_unit {
public:
    bool is_free() const { return ! p_truck_; }
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
    mytime::Time processing_length;
};

void skip_heading(std::istream& is, char sentinel);
