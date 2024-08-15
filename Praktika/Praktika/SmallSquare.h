#pragma once
#include "Base.h"

ref class SmallSquare : public Base
{
public:
    SmallSquare();
    SmallSquare(int xb, int yb, int ab, Color c);
    ~SmallSquare() override;

    void Show(Graphics^ g) override;
    void Hide(Graphics^ g, SolidBrush^ backgroundBrush) override;
};