// Task9.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <iostream>

using namespace std;

int main()
{
	int const sizeOfArray = 10000;
	bool numbers[sizeOfArray];
	int i = 0, j=0;
	int n = 0;

	cout << "Enter n: " << endl;
	cin >> n;
	
	for (i = 2; i < n; i++) {
		numbers[i] = true;
	}

	for (i = 2; (i < (n / 2)); i++) {
		if (numbers[i]) {
			for (j = 2 * i; j < n; j++) {
				if ((j % i) == 0) {
					numbers[j] = false;
				}
			}
		}
	}

	cout << "Simple numbers: " << endl;

	for (i = 2; i < n; i++) {
		if (numbers[i]) {
			cout << i << " ";
		}
	}

	return 0;
}

