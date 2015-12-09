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
	int get_x() const{ return x_; }
	int get_y() const{ return y_; }

	void set_x(int a){ x_ = a; }
	void set_y(int a){ y_ = a; }
	
protected:
	int x_;
	int y_;
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
void move_along_line(CClientDC& dc, Shape& s, int x1, int y1);
void rmove_along_line(CClientDC& dc, Shape& s, int x, int y);