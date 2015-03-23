#include <iostream>
#include <string.h>
#include <ctime>
#include <cstdlib>
#include <algorithm>

using namespace std;

int const sizeOfArray = 50; // ������ �������
int const rangeOfRandNumb = 25; // �������� ��������� �����

void fillArray(int arrayOfNumbs[]) // �������, ������� ��������� ������ � ��������� ��� ���������� ����������
{
	for (int i = 1; i != sizeOfArray; i++)
	{
		arrayOfNumbs[i] = rand() % rangeOfRandNumb;
	}
}

void showArray(int arrayOfNumbs[]) // ����� ��������� ������� �� �����
{
	for (int i = 1; i != sizeOfArray; i++)
	{
		cout << arrayOfNumbs[i] << endl;
	}
}

void insertSort(int arrayOfNumbs[], int aLeft, int aRight) // �������� ���������� ���������
{
	for (int i = aLeft + 1; i != aRight+1; ++i)
	{
		int j = i;
		while (j > 1 && arrayOfNumbs[j] < arrayOfNumbs[j - 1])
		{
			swap(arrayOfNumbs[j], arrayOfNumbs[j - 1]);
			--j;
		}
	}

}

int partition(int arrayOfNumbs[], int aLeft, int aRight) // ������� ���������� �����������
{
	int temporaryPivot = arrayOfNumbs[aLeft]; // �������, ���������� ������������
	int i = aLeft; 
	int j = i; // ���������, ������� � ����� ������� ����� ��������� �� ������� �������, � �������
									// ����� ����� ����������� ������ ������� �������
	for (i = aLeft + 1; i != aRight+1; ++i) // ��������� ����, ����� �������� ����� ������� ����� ������������ ���������
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

void qSort(int arrayOfNumbs[], int aLeft, int aRight) // �������� ������� ����������
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
		int pivot = partition(arrayOfNumbs, aLeft, aRight); // �����������
		qSort(arrayOfNumbs, aLeft, pivot - 1);
		qSort(arrayOfNumbs, pivot + 1, aRight);
	}
}

int main()
{
	int arrayOfNumbs[sizeOfArray];

	srand(time(nullptr));

	cout << "Unsorted array." << endl;
	fillArray(arrayOfNumbs);
	showArray(arrayOfNumbs);

	qSort(arrayOfNumbs, 1, sizeOfArray-1);

	cout << "Sorted array." << endl;
	showArray(arrayOfNumbs);
	
	return 0;
}

//��� �����.
//������� ������: 
//32
//54
//3
//2
//66
//7
//432
//645
//7
//58
//23
//668
//97
//1
//6
//48
//665
//654
//234
//453
//7
//45
//8
//24
//53
//
//�������� ������:
//1
//2
//3
//6
//7
//7
//7
//8
//23
//24
//32
//45
//48
//53
//54
//58
//66
//97
//234
//432
//453
//645
//654
//665
//668
//______
//
//������� ������:
//5234
//5345
//65
//23
//5476
//4
//5
//3
//5
//7
//54
//5
//564
//756
//8
//45
//3543
//4567
//58
//689
//6
//74
//6
//356
//45
//6757
//53
//745
//6245
//345
//87
//65
//
//�������� ������:
//3
//4
//5
//5
//5
//6
//6
//7
//8
//23
//45
//45
//53
//54
//58
//65
//65
//74
//87
//345
//356
//564
//689
//745
//756
//3543
//4567
//5234
//5345
//5476
//6245
//6757
//_________
//
//������� ������: 
//1
//0
//
//�������� ������:
//0
//1