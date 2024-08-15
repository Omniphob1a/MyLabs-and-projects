#pragma once
#include "Base.h"

ref class BigSquare : public Base
{
public:
    BigSquare();
    BigSquare(int xb, int yb, int ab, int smallCount, Color c);
    ~BigSquare() override;

    void Show(Graphics^ g) override;
    void Hide(Graphics^ g, SolidBrush^ backgroundBrush) override;
private:
    int sideCount;
    array<SmallSquare^>^ v;
};