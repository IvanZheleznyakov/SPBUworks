// Task4.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <iostream>

using namespace std;

int main()
{
	int divident = 0;
	int divider = 0;

	cout << "Enter divident and divider: ";
	cin >> divident >> divider;
	cin.ignore();

	bool signOfQuotientIsPlus = divident*divider > 0; 

	divident = abs(divident);
	divider = abs(divider);

	int quotient = 0;

	while (divident > divider) 
	{
		divident -= divider;
		++quotient;
	}

	if (!signOfQuotientIsPlus) 
	{
		quotient = -quotient;
	}

	cout << "Quotient: " << quotient << endl;

	return 0;
}

