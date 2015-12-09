// LorryQueueDlg.cpp : implementation file
//
#include "stdafx.h"
#include "graphic_classes.h"

// graphical stuff

// static vars
std::vector<Point> Dot::coords;
bool Dot::coords_setup{ false };

Dot::Dot() {
    if (!coords_setup) {
        coords_setup = true;
        coords.reserve(12);
        coords.emplace_back(0, 1);
        coords.emplace_back(0, 2);
        coords.emplace_back(1, 0);
        coords.emplace_back(1, 1);
        coords.emplace_back(1, 2);
        coords.emplace_back(1, 3);
        coords.emplace_back(2, 0);
        coords.emplace_back(2, 1);
        coords.emplace_back(2, 2);
        coords.emplace_back(2, 3);
        coords.emplace_back(3, 1);
        coords.emplace_back(3, 2);
    }
    undo_colours.reserve(coords.size());
}

void Dot::draw(CClientDC& dc, int x, int y) {
    undo_colours.clear();
    for (auto& e : coords) {
        int x1 = x + e.x;
        int y1 = y + e.y;
        undo_colours.emplace_back(x1, y1, dc.GetPixel(x1, y1));
        dc.SetPixel(x1, y1, col_);
    }
}

void Dot::undraw(CClientDC& dc) {
    for (auto& e : undo_colours)
        dc.SetPixel(e.x, e.y, e.c);
}

void move_along_line(CClientDC& dc, Shape& s, int x0, int y0, int x1, int y1) {
    double dx = x1 - x0;
    double dy = y1 - y0;
    if (fabs(dy) < fabs(dx)) {
        auto m = dy / dx;
        auto c = y0 - m*x0;
        if (x0 <= x1) {
            for (int x = x0; x < x1; ++x) {
                s.undraw(dc);
                s.draw(dc, x, static_cast<int>(m*x + c + 0.5));
            }
        }
        else {
            for (int x = x0; x > x1; --x) {
                s.undraw(dc);
                s.draw(dc, x, static_cast<int>(m*x + c + 0.5));
            }
        }
    }
    else {
        auto m = dx / dy;
        auto c = x0 - m*y0;
        if (y0 <= y1) {
            for (int y = y0; y < y1; ++y) {
                s.undraw(dc);
                s.draw(dc, static_cast<int>(m*y + c + 0.5), y);
            }
        }
        else {
            for (int y = y0; y > y1; --y) {
                s.undraw(dc);
                s.draw(dc, static_cast<int>(m*y + c + 0.5), y);
            }
        }
    }
}

