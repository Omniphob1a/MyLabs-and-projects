#include "ComplexFigure.h"
#include "BigSquare.h"
#include "SmallSquare.h"
using namespace std;

void ComplexFigure::show()
{
	bsquare->show();
	ssquare->show();
}

void ComplexFigure::hide()
{
	bsquare->hide();
	ssquare->hide();
}
void ComplexFigure::moveto(int x1, int y1)
{
	bsquare->moveto(x1, y1);
	ssquare->moveto(x1, y1);
	bsquare->show();
	ssquare->show();
}