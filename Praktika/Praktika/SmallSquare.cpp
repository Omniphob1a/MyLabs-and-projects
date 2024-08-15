#include "SmallSquare.h"

SmallSquare::SmallSquare() {
    x = y = a = 0;
    colors = Color::Black;
}

SmallSquare::SmallSquare(int xb, int yb, int ab, Color c) {
    x = xb;
    y = yb;
    a = ab;
    colors = c;
}

void SmallSquare::Show(Graphics^ g) {
    SolidBrush^ brush = gcnew SolidBrush(colors);
    g->FillRectangle(brush, x, y, a, a);
}

void SmallSquare::Hide(Graphics^ g, SolidBrush^ backgroundBrush) {
    g->FillRectangle(backgroundBrush, x, y, a, a);
}

SmallSquare::~SmallSquare() {

}