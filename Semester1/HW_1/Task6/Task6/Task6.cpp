// Task6.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <iostream>

using namespace std;

int main()
{
	int count = 0;
	int tickets[28];
	int const dimension = 10;

	for (int i = 0; i < 28; i++) {
		tickets[i] = 0;
	}

	for (int i = 0; i < dimension; i++) {
		for (int k = 0; k < dimension; k++) {
			for (int l = 0; l < dimension; l++) {
				++tickets[i + k + l];
			}
		}
	}

	for (int i = 0; i < 28; i++) {
		count += tickets[i] * tickets[i];
	}

	cout << "Happy tickets: " << count << endl;

	return 0;

}

