#include "DinArray.h"
#include <iostream>
using namespace std;

void dinarray::add(Base* figure)
{
	v.push_back(figure);
}

void dinarray::print()
{
	for (int i = 0; i < v.size(); i++)
	{
		v[i]->show();
	}
}

void dinarray::clear()
{
	v.clear();
}