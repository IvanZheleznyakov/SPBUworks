#include <iostream>
#include <string.h>
#include <ctime>
#include <cstdlib>
#include <algorithm>
#include <fstream>

#include "qsort.h"

using namespace std;

const size_t maxSizeOfArray = 100; // ������������ ����� �������

void showArray(int arrayOfNumbs[], int sizeOfArray) // ����� ��������� ������� �� �����
{
	for (size_t i = 1; i != sizeOfArray + 1; i++)
	{
		cout << arrayOfNumbs[i] << endl;
	}
}

int oftenElement(int arrayOfNumbs[], int sizeOfArray) // �������, ������������ �������� ����� ������������� �������
{
	int elementsInARow = 0;
	int maxElementsInARow = 0;
	int temporaryOftenElement = arrayOfNumbs[1];
	for (size_t i = 1; i != sizeOfArray - 1; ++i)
	{
		if (arrayOfNumbs[i] == arrayOfNumbs[i + 1])      // ���� ��� ������� ����� �������� �����, �� �����������
		{														// ������� ������ ������ ������ ��������� 
			++elementsInARow;
		}
		else
		{
			if (elementsInARow > maxElementsInARow)      // ���� �� �������� �� �����, ���������� ���������� ������ ��
			{												// ����� ��������� ������ � ������������ ����������� ���������,
				maxElementsInARow = elementsInARow;           // ������� �����
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
	input >> realSizeOfArray; // ������ ����� - ���������� ��������� � �������
	for (size_t i = 1; i != realSizeOfArray + 1; ++i)
	{
		input >> arrayOfNumbs[i];
	}

	input.close();

	cout << "������:" << endl;
	showArray(arrayOfNumbs, realSizeOfArray);

	qSort(arrayOfNumbs, 1, realSizeOfArray - 1);

	cout << "�������� ����� ������������� �������: " << oftenElement(arrayOfNumbs, realSizeOfArray) << endl;

	return 0;
}

//��� �����.
//������� ������ :
//29
//1 4 4 5 3 4 7 5 3 5 3 3 3 3 5 6 7 6 5 7 7 7 8 5 3 3 3 3 7
//�������� ������ :
//3
//_________
//
//������� ������ :
//6
//1 2 1 1 2 2
//�������� ������ :
//1
//_________
//
//������� ������ :
//7
//-1 2 -1 1 -2 2 121
//�������� ������:
//-1