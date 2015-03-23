#include <iostream>
#include <string.h>
#include <ctime>
#include <cstdlib>

using namespace std;

int const sizeOfArray = 30; // ������ ������������ �������
int const rangeOfRandNumb = 25; // �������� ����� � �������

void fillArray(int arrayOfNumbs[]) // �������, ������� ��������� ������ � ��������� ��� ���������� ����������
{
	for (int i = 0; i < sizeOfArray; i++)
	{
		arrayOfNumbs[i] = rand() % rangeOfRandNumb;
	}
}

void showArray(int arrayOfNumbs[]) // ����� ��������� ������� �� �����
{
	for (int i = 0; i < sizeOfArray; i++)
	{
		cout << arrayOfNumbs[i] << endl;
	}
}

int findOftenElement(int arrayOfNumbs[]) // ������� ���������� �������� ����� ������������� �������� � �������
{
	int helpArray[rangeOfRandNumb] = {0}; // ��������������� ������
	int oftenElement = 0;                  
	int countFrequency = 0;               // ����������, ���������� �������� ���������� ������� �������� � �������

	for (int i = 0; i != sizeOfArray; ++i)     // ���� �� ����� �������
	{
		++helpArray[arrayOfNumbs[i]];          // ����������� ������ �������� ���������������� �������,
													// ������ �������� ������������ �������
		if (helpArray[arrayOfNumbs[i]] > countFrequency)     // ���� ������� ����������� ������ ���, ��� ��������� 		
		{														// �������, ��
			++countFrequency;									// ����������� ������������ ������� �� �������
			oftenElement = arrayOfNumbs[i];						// � ���������� ������� �������
		}
	}

	return oftenElement;
}

int main()
{
	srand(time(nullptr));

	int arrayOfNumbs[sizeOfArray] = {0};

	fillArray(arrayOfNumbs);
	
	cout << "Array: " << endl;
	showArray(arrayOfNumbs);

	cout << "The most frequent element is: " << findOftenElement(arrayOfNumbs);

	return 0;
}