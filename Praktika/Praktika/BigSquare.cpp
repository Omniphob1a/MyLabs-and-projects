#include "BigSquare.h"

BigSquare::BigSquare() {
    x = y = a = 0;
    sideCount = 0;
    colors = Color::Black;
    v = nullptr;
}

BigSquare::BigSquare(int xb, int yb, int ab, int smallCount, Color c) {
    x = xb;
    y = yb;
    a = ab;
    sideCount = smallCount;
    colors = c;
    v = gcnew array<SmallSquare^>(smallCount * smallCount);
    int side = ab / smallCount;
    int k = 0; // счетчик
    for (int i = 0; i < smallCount; i++) {
        for (int j = 0; j < smallCount; j++) {
            v[k++] = gcnew SmallSquare(x + i * side, y + j * side, side, colors);
        }
    }
}

void BigSquare::Show(Graphics^ g) {
    for (int i = 0; i < sideCount * sideCount; i++) {
        v[i]->Show(g);
    }
}

void BigSquare::Hide(Graphics^ g, SolidBrush^ backgroundBrush) {
    for (int i = 0; i < sideCount * sideCount; i++) {
        v[i]->Hide(g, backgroundBrush);
    }
}

BigSquare::~BigSquare() {
    delete[] v;
}