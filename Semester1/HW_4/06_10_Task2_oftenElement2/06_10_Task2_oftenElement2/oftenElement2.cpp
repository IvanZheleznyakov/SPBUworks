#include <iostream>
#include <string.h>
#include <ctime>
#include <cstdlib>
#include <algorithm>
#include <fstream>

#include "qsort.h"

using namespace std;

const size_t maxSizeOfArray = 100; // максимальная длина массива

void showArray(int arrayOfNumbs[], int sizeOfArray) // вывод элементов массива на экран
{
	for (size_t i = 1; i != sizeOfArray + 1; i++)
	{
		cout << arrayOfNumbs[i] << endl;
	}
}

int oftenElement(int arrayOfNumbs[], int sizeOfArray) // функция, возвращающая наиболее часто встречающийся элемент
{
	int elementsInARow = 0;
	int maxElementsInARow = 0;
	int temporaryOftenElement = arrayOfNumbs[1];
	for (size_t i = 1; i != sizeOfArray - 1; ++i)
	{
		if (arrayOfNumbs[i] == arrayOfNumbs[i + 1])      // если два стоящих рядом элемента равны, то увеличиваем
		{														// счетчик подряд идущих равных элементов 
			++elementsInARow;
		}
		else
		{
			if (elementsInARow > maxElementsInARow)      // если же элементы не равны, сравниваем количество идущих до
			{												// этого элементов подряд с максимальным количеством элементов,
				maxElementsInARow = elementsInARow;           // стоящих рядом
				temporaryOftenElement = arrayOfNumbs[i];
			}
			elementsInARow = 0;
		}
	}
	return temporaryOftenElement;
}

int main()
{
	setlocale(LC_ALL, "Russian");

	int arrayOfNumbs[maxSizeOfArray];

	ifstream input("numbersForSort.txt");
	int realSizeOfArray = 0;
	input >> realSizeOfArray; // первое число - количество элементов в массиве
	for (size_t i = 1; i != realSizeOfArray + 1; ++i)
	{
		input >> arrayOfNumbs[i];
	}

	input.close();

	cout << "Массив:" << endl;
	showArray(arrayOfNumbs, realSizeOfArray);

	qSort(arrayOfNumbs, 1, realSizeOfArray - 1);

	cout << "Наиболее часто встречающийся элемент: " << oftenElement(arrayOfNumbs, realSizeOfArray) << endl;

	return 0;
}

//Мои тесты.
//Входные данные :
//29
//1 4 4 5 3 4 7 5 3 5 3 3 3 3 5 6 7 6 5 7 7 7 8 5 3 3 3 3 7
//Выходные данные :
//3
//_________
//
//Входные данные :
//6
//1 2 1 1 2 2
//Выходные данные :
//1
//_________
//
//Входные данные :
//7
//-1 2 -1 1 -2 2 121
//Выходные данные:
//-1