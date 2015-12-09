// graphical stuff

#pragma once

#include <vector>

//using COLORREF = unsigned long;

struct Point {
    Point(int x1, int y1) : x{ x1 }, y{ y1 } {}
    int x;
    int y;
};

struct PointColour {
    PointColour(int x1, int y1, COLORREF c1) : x{ x1 }, y{ y1 }, c{ c1 } {}
    int x;
    int y;
    COLORREF c;
};

class Shape {
public:
    virtual ~Shape() {}
    virtual void draw(CClientDC& dc, int x, int y) = 0;
    virtual void undraw(CClientDC& dc) = 0;
};

class Dot : public Shape {
public:
    Dot();
    void draw(CClientDC& dc, int x, int y) override;
    void undraw(CClientDC& dc) override;
private:
    COLORREF col_{ 0 };
    static std::vector<Point> coords;
    static bool coords_setup;
    std::vector<PointColour> undo_colours;
};

void move_along_line(CClientDC& dc, Shape& s, int x0, int y0, int x1, int y1);
