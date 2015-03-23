#include "qsort.h"
#include <algorithm>

using namespace std;

void insertSort(int arrayOfNumbs[], size_t aLeft, size_t aRight) // �������� ���������� ���������
{
	for (size_t i = aLeft + 1; i != aRight + 1; ++i)
	{
		size_t j = i;
		while (j > 1 && arrayOfNumbs[j] < arrayOfNumbs[j - 1])
		{
			swap(arrayOfNumbs[j], arrayOfNumbs[j - 1]);
			--j;
		}
	}
}

int partition(int arrayOfNumbs[], size_t aLeft, size_t aRight) // ������� ���������� �����������
{
	// �������, ���������� ������������
	int temporaryPivot = arrayOfNumbs[aLeft];
	size_t i = aLeft;
	size_t j = i; // ���������, ������� � ����� ������� ����� ��������� �� ������� �������, � �������
	// ����� ����� ����������� ������ ������� �������
	for (i = aLeft + 1; i != aRight + 1; ++i) // ��������� ����, ����� �������� ����� ������� ����� ������������ ���������
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

void qSort(int arrayOfNumbs[], size_t aLeft, size_t aRight) // �������� ������� ����������
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