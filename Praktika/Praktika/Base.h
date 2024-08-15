#pragma once
#include <cliext/vector>
using namespace System;
using namespace System::Drawing;
using namespace cliext;

ref class Base
{
public:
    int x;
    int y;
    int a;
    Color colors;

    Base() = default;
    Base(int xb, int yb, int ab);

    virtual ~Base() = 0;
    virtual void Show(Graphics^ g) = 0;
    virtual void Hide(Graphics^ g, SolidBrush^ backgroundBrush) = 0;
    void MoveTo(int xb, int yb);
};