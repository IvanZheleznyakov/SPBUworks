#include <iostream>
#include <string.h>
#include <ctime>
#include <cstdlib>
#include <algorithm>

using namespace std;

const size_t sizeOfArray = 7; // ������ �������
const size_t rangeOfRandNumb = 5; // �������� ��������� �����

void fillArray(size_t arrayOfNumbs[]) // �������, ������� ��������� ������ � ��������� ��� ���������� ����������
{
	for (size_t i = 0; i != sizeOfArray; i++)
	{
		arrayOfNumbs[i] = rand() % rangeOfRandNumb;
	}
}

void showArray(size_t arrayOfNumbs[]) // ����� ��������� ������� �� �����
{
	for (size_t i = 0; i != sizeOfArray; i++)
	{
		cout << arrayOfNumbs[i] << endl;
	}
}

void insertSort(size_t arrayOfNumbs[], size_t aLeft, size_t aRight) // �������� ���������� ���������
{
	for (size_t i = aLeft; i != aRight; ++i)
	{
		size_t j = i;
		while (j > 0 && arrayOfNumbs[j] < arrayOfNumbs[j - 1])
		{
			swap(arrayOfNumbs[j], arrayOfNumbs[j - 1]);
			--j;
		}
	}

}

size_t partition(size_t arrayOfNumbs[], size_t aLeft, size_t aRight) // ������� ���������� �����������
{
	size_t temporaryPivot = arrayOfNumbs[aLeft]; // �������, ���������� ������������
	size_t i = aLeft;
	size_t j = i; // ���������, ������� � ����� ������� ����� ��������� �� ������� �������, � �������
	// ����� ����� ����������� ������ ������� �������
	for (i = aLeft; i != aRight; ++i) // ��������� ����, ����� �������� ����� ������� ����� ������������ ���������
	{                                              // �������: ��� ������ k �� aLeft �� j ������� � �������� k ����� ������
		if (arrayOfNumbs[i] <= temporaryPivot)            // ���� ����� ������� ��������, � ��� ������ k �� j+1 �� i
		{                                                  // ������� � �������� k ������ ������� ��������
			++j;
			swap(arrayOfNumbs[j], arrayOfNumbs[i]);
		}
	}
	swap(arrayOfNumbs[aLeft], arrayOfNumbs[j]);
	return j;
}

void qSort(size_t arrayOfNumbs[], size_t aLeft, size_t aRight) // �������� ������� ����������
{
	if (aLeft >= aRight)
	{
		return;
	}
	if (aRight - aLeft < 10) //						���� ��������� � ����� ������� ������ 10, ��
	{
		insertSort(arrayOfNumbs, aLeft, aRight);       // �������� ��������� ��������� ���������
	}
	else
	{
		size_t pivot = partition(arrayOfNumbs, aLeft, aRight); // �����������
		qSort(arrayOfNumbs, aLeft, pivot - 1);
		qSort(arrayOfNumbs, pivot + 1, aRight);
	}
}

size_t oftenElement(size_t arrayOfNumbs[]) // �������, ������������ �������� ����� ������������� �������
{
	size_t elementsInARow = 0;
	size_t maxElementsInARow = 0;
	size_t temporaryOftenElement = arrayOfNumbs[0];
	for (size_t i = 1; i != sizeOfArray; ++i)
	{
		if (arrayOfNumbs[i] == arrayOfNumbs[i - 1])      // ���� ��� ������� ����� �������� �����, �� �����������
		{														// ������� ������ ������ ������ ��������� 
			++elementsInARow;
			if (i == sizeOfArray - 1 && elementsInARow > maxElementsInARow)      
			{												
				maxElementsInARow = elementsInARow;           
				temporaryOftenElement = arrayOfNumbs[i - 1];
			}
		}
		else
		{
			if (elementsInARow > maxElementsInARow)      // ���� �� �������� �� �����, ���������� ���������� ������ ��
			{												// ����� ��������� ������ � ������������ ����������� ���������,
				maxElementsInARow = elementsInARow;           // ������� �����
				temporaryOftenElement = arrayOfNumbs[i - 1];
			}
			elementsInARow = 0;
		}
	}
	return temporaryOftenElement;
}

int main()
{
	setlocale(LC_ALL, "Russian");

	size_t arrayOfNumbs[sizeOfArray];

	srand(time(nullptr));

	cout << "������:" << endl;
	fillArray(arrayOfNumbs);
	//for (int i = 0; i != sizeOfArray; ++i)
	//{
	//	cin >> arrayOfNumbs[i];
	//}
	showArray(arrayOfNumbs);

	qSort(arrayOfNumbs, 0, sizeOfArray);

	showArray(arrayOfNumbs);

	cout << "�������� ����� ������������� �������: " << oftenElement(arrayOfNumbs) << endl;

	return 0;
}

//��� �����.
//������� ������ :
//1 4 4 5 3 4 7 5 3 5 3 3 3 3 5 6 7 6 5 7 7 7 8 5 3 3 3 3 7
//�������� ������ :
//3
//_________
//
//������� ������ :
//1 2 1 1 2 2
//�������� ������ :
//1