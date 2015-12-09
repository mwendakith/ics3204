// LorryQueueDlg.cpp : implementation file
//
#include "stdafx.h"
#include "simulation.h"

int Truck::current_no_{};

std::ofstream out("output.txt");

void Arrival::run_task(CClientDC& dc) { // uses Truck
    const int truck_source_x = 1000;
    const int truck_source_y = 200;
    const int queue_front_x = 300;
    const int space_per_truck = 10;
    out << time_.str() << ": arrival of truck no " << std::setw(3) << p_truck_->id() << "\t\t\t";
    move_along_line( dc, p_truck_->getGraphic(), truck_source_x, truck_source_y,
                     queue_front_x + space_per_truck * p_sd_->truck_queue.size(), truck_source_y);
    for (auto& p : p_sd_->pro_units) {
        if (p->is_free()) {
            p->add(p_truck_);
            auto pe = std::make_shared<Completed>(time_ + p_sd_->processing_length, *p);
            p_sd_->event_queue.emplace(pe);
            pe->set(*p_sd_);
            print_status(*p_sd_);
            // to do move_along_line to processing unit
            return;
        }
    }
    p_sd_->truck_queue.emplace(p_truck_);
    print_status(*p_sd_);
}

void Completed::run_task(CClientDC& dc) {
    auto p_truck = p_processing_unit_->remove();
    auto completion_time = time_ - p_truck->arrival_time();
    out << time_.str() << ": completion of truck no "
              << std::setw(3) << p_truck->id() << " after " << completion_time.str() << "\t";
    if (!p_sd_->truck_queue.empty()) {
        p_processing_unit_->add(p_sd_->truck_queue.front());
        p_sd_->truck_queue.pop();
        auto pe = std::make_shared<Completed>(time_ + p_sd_->processing_length, *p_processing_unit_);
        p_sd_->event_queue.emplace(pe);
        pe->set(*p_sd_);
    }
    print_status(*p_sd_);
}

void Event::print_status(SimilulationData& sd) {
    out << "Status: processing: ";
    for (auto& p : sd.pro_units) {
        if (!p->is_free())
            out << p->truck_id() << ", ";
    }
    out << "queue: " << sd.truck_queue.size() << "\n";
}

void skip_heading(std::istream& is, char sentinel) {
    while (is) {
        if (is.get() == sentinel) return;
    }
}

