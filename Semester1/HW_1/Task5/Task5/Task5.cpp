// Task5.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <iostream>

using namespace std;

int const sizeOfArray = 1000;

void reverse(int arrayOfNumbs[], int left, int right)
{
	for (int i = left; i <= ((left + right) / 2); i++) 
	{
		int sub = arrayOfNumbs[i];
		arrayOfNumbs[i] = arrayOfNumbs[right + left - i];
		arrayOfNumbs[right + left - i] = sub;
	}
		
}

int main()
{
	int m = 0;
	int n = 0;

	cout << "Enter m and n: " << endl;
	cin >> m >> n;
	cin.ignore();

	cout << "Enter elements of array: " << endl;

	int arrayOfNumbs[sizeOfArray];
	
	for (int k = 0; k < m + n; k++) 
	{
		cin >> arrayOfNumbs[k];
	}
	
	reverse(arrayOfNumbs, 0, m - 1);
	reverse(arrayOfNumbs, m, m + n - 1);
	reverse(arrayOfNumbs, 0, m + n - 1);

	cout << "Final array: " << endl;

	for (int k = 0; k < m + n; k++) 
	{
		cout << arrayOfNumbs[k] << endl;
	}

	return 0;

}