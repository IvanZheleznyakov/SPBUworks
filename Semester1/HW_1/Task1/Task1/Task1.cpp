// Task1.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <iostream>

using namespace std;

int main()
{
	int x = 0;

	cout << "Enter x: ";
	cin >> x;
	cin.ignore();

	int square = x * x;

	x = (square + x) * (square + 1) + 1;

	cout << "Result: " << x << endl;

	return 0;
}

// x^2*(x^2+1)+x*(x^2+1)+1=(x^2+1)*(x^2+x)+1; int  