#include "Base.h"

Base::Base(int xb, int yb, int ab) {
    x = xb;
    y = yb;
    a = ab;
}

void Base::MoveTo(int xb, int yb) {
    Hide();
    x = xb;
    y = yb;
    Show();
}

Base::~Base() {
}