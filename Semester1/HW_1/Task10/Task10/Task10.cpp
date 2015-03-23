// Task10.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <iostream>

using namespace std;

int main()
{
	int const sizeOfArray = 1000; 
	int arrayOfNumbs[sizeOfArray];
	int count = 0;
	int i = 0;

//	srand(time(nullptr));

	for (i = 0; i < sizeOfArray; i++) {
		arrayOfNumbs[i] = 0 + rand() % 10;
		if (arrayOfNumbs[i] == 0) {
			++count;
		}
	}

	cout << "Number of zeros: " << count << endl;

	return 0;
}

