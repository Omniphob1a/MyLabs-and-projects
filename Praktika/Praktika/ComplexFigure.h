#pragma once
#include "Base.h"
#include "BigSquare.h"
#include "SmallSquare.h"

class ComplexFigure : public Base
{
private:
	BigSquare* bsquare;
	SmallSquare* ssquare;
public:
	ComplexFigure() {};
	ComplexFigure(int x, int y, int a, COLORREF colors) {
		bsquare = new BigSquare(x, y, a, colors);
		ssquare = new SmallSquare(x, y, a, colors);
	}
	void show();
	void hide();
	void moveto(int xb, int yb);
	~ComplexFigure() {};
};