#include "qsort.h"
#include <algorithm>

using namespace std;

void insertSort(int arrayOfNumbs[], size_t aLeft, size_t aRight) // алгоритм сортировки вставками
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

int partition(int arrayOfNumbs[], size_t aLeft, size_t aRight) // функци€ нахождени€ разделител€
{
	// элемент, €вл€ющийс€ разделителем
	int temporaryPivot = arrayOfNumbs[aLeft];
	size_t i = aLeft;
	size_t j = i; // указатель, который в конце функции будет указывать на элемент массива, в который
	// нужно будет переместить первый элемент массива
	for (i = aLeft + 1; i != aRight + 1; ++i) // запускаем цикл, после которого кусок массива будет преобразован следующим
	{                                              // образом: дл€ любого k от aLeft до j элемент с индексом k будет меньше
		if (arrayOfNumbs[i] <= temporaryPivot)            // либо равен первого элемента, а дл€ любого k от j+1 до i
		{                                                  // элемент с индексом k больше первого элемента
			++j;
			swap(arrayOfNumbs[j], arrayOfNumbs[i]);
		}
	}
	swap(arrayOfNumbs[aLeft], arrayOfNumbs[j]);
	return j;
}

void qSort(int arrayOfNumbs[], size_t aLeft, size_t aRight) // алгоритм быстрой сортировки
{
	if (aLeft >= aRight)
	{
		return;
	}
	if (aRight - aLeft < 10) //						если элементов в куске массива меньше 10, то
	{
		insertSort(arrayOfNumbs, aLeft, aRight);       // вызываем процедуру алгоритма вставками
	}
	else
	{
		int pivot = partition(arrayOfNumbs, aLeft, aRight); // разделитель
		qSort(arrayOfNumbs, aLeft, pivot - 1);
		qSort(arrayOfNumbs, pivot + 1, aRight);
	}
}