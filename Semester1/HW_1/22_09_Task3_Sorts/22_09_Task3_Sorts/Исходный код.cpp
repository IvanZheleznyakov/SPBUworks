#include <iostream>
#include <ctime>
#include <string.h>
#include <cstdlib>

using namespace std;

int const sizeOfArray = 10;
int const rangeOfRandNumbs = 100;

void fillArray(int arrayOfNumbs[])
{
	for (int i = 0; i < sizeOfArray; i++)
	{
		arrayOfNumbs[i] = rand() % rangeOfRandNumbs;
	}
}

void showArray(int arrayOfNumbs[])
{
	for (int i = 0; i < sizeOfArray; i++)
	{
		cout << arrayOfNumbs[i] << " ";
	}
}

void fillAndShowArray(int arrayOfNumbs[])
{
	fillArray(arrayOfNumbs);
	showArray(arrayOfNumbs);
}

void countSort(int arrayOfNumbs[])
{
	int helpArray[rangeOfRandNumbs] = { 0 };
	for (int i = 0; i < sizeOfArray; i++)
	{
		++helpArray[arrayOfNumbs[i]];
	}
	int k = 0;
	for (int i = 0; i < rangeOfRandNumbs; i++)
	{
		for (int j = 0; j < helpArray[i]; j++)
		{
			arrayOfNumbs[k] = i;
			++k;
		}
	}
}

void bubbleSort(int arrayOfNumbs[])
{
	for (int i = 0; i < sizeOfArray - 1; i++)
	{
		for (int j = 0; j < sizeOfArray - i - 1; j++)
		{
			if (arrayOfNumbs[j] > arrayOfNumbs[j + 1])
			{
				int sub = arrayOfNumbs[j];
				arrayOfNumbs[j] = arrayOfNumbs[j + 1];
				arrayOfNumbs[j + 1] = sub;
			}
		}
	}
}

int main()
{
	int arrayOfNumbs[sizeOfArray];

	srand(time(nullptr));
	
	cout << "Unsorted array: " << endl;

	fillAndShowArray(arrayOfNumbs);

	cout << endl;
	cout << "Sorted array (count sort): " << endl;

	countSort(arrayOfNumbs);
	showArray(arrayOfNumbs);

	cout << endl << endl;

	cout << "Unsorted array: " << endl;

	fillAndShowArray(arrayOfNumbs);

	cout << endl;
	cout << "Sorted array (bubble sort): " << endl;

	bubbleSort(arrayOfNumbs);
	showArray(arrayOfNumbs);

	return 0;

}