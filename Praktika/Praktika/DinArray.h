#pragma once
#include <iostream>
#include "Base.h"
#include <vector>
using namespace std;

class dinarray
{
public:
	vector<Base*>v;
	void add(Base* figure);
	void print();
	void clear();
	~dinarray() {};
};