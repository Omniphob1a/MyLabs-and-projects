//Динамический массив. Базовый класс. Композиция
//Квадрат, наклоненный под углом и вписанный в квадрат(есть координаты вершины и длина стороны большого квадрата)
//Шмоленко 26 вариант
#include <iostream>
#include "BigSquare.h"
#include "SmallSquare.h"
#include "ComplexFigure.h"
#include "DinArray.h"
#include <vector>
using namespace std;
const int Fon = system("color F0");

int main()
{
    setlocale(LC_ALL, "ru");
    SetConsoleTitle((LPCWSTR)L"22VP1_26_Shmolenko_Squares");
    BigSquare* bsquare = new BigSquare(200, 200, 100, RGB(255, 0, 0));
    SmallSquare* ssquare = new SmallSquare(200, 200, 100, RGB(0, 0, 128));
    try
    {
        ComplexFigure* figure = new ComplexFigure(200, 200, 100, RGB(160, 160, 160));
        dinarray ar;
        ar.add(bsquare);
        ar.add(ssquare);
        ar.add(figure);

        bsquare->show();
        Sleep(1000);
        bsquare->hide();
        Sleep(1000);

        ssquare->show();
        Sleep(1000);
        ssquare->hide();
        Sleep(1000);

        figure->show();
        Sleep(1000);
        figure->hide();
        Sleep(1000);

        figure->show();
        Sleep(1000);
        figure->moveto(300, 300);
        Sleep(1000);
        figure->hide();

        for (int i = 0; i < ar.v.size(); i++)
        {
            ar.print();
        }
        ar.clear();

        delete figure;
    }
    catch (Base::Border)
    {
        cout << "Выход за границы" << endl;
    }
    return 0;
}