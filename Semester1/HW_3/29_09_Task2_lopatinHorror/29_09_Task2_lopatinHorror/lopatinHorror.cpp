#include <iostream>
#include <string.h>
#include <ctime>
#include <cstdlib>
#include <algorithm>

using namespace std;

const size_t maxSizeOfArray = 5001; // максимальный размер массива
const size_t rangeOfRandNumb = 1000000001; // диапазон случайных чисел

void fillArray(size_t arrayOfNumbs[], size_t sizeOfArray) // функци€, котора€ принимает массив и заполн€ет его случайными значени€ми
{
	for (size_t i = 1; i != sizeOfArray; i++)
	{
		arrayOfNumbs[i] = rand() % rangeOfRandNumb;
	}
}

void insertSort(size_t arrayOfNumbs[], size_t aLeft, size_t aRight) // алгоритм сортировки вставками
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

int partition(size_t arrayOfNumbs[], size_t aLeft, size_t aRight) // функци€ нахождени€ разделител€
{
	size_t temporaryPivot = arrayOfNumbs[aLeft]; // элемент, €вл€ющийс€ разделителем
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

void qSort(size_t arrayOfNumbs[], size_t aLeft, size_t aRight) // алгоритм быстрой сортировки
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
		size_t pivot = partition(arrayOfNumbs, aLeft, aRight); // разделитель
		qSort(arrayOfNumbs, aLeft, pivot - 1);
		qSort(arrayOfNumbs, pivot + 1, aRight);
	}
}

void findSameElements(size_t firstArrayOfNumbs[], size_t secondArrayOfNumbs[], size_t sizeOfFirstArray, size_t sizeOfSecondArray, bool thereAreElements)
{
	size_t firstPointer = 1;
	size_t secondPointer = 1;
	while (firstPointer <= sizeOfFirstArray && secondPointer <= sizeOfSecondArray)
	{
		if (secondArrayOfNumbs[secondPointer] < firstArrayOfNumbs[firstPointer])
		{
			++secondPointer;
		}
		else if (secondArrayOfNumbs[secondPointer] > firstArrayOfNumbs[firstPointer])
		{
			++firstPointer;
		}
		else if (secondArrayOfNumbs[secondPointer] == firstArrayOfNumbs[firstPointer])
		{
			thereAreElements = true;
			cout << secondArrayOfNumbs[secondPointer] << endl;
			++secondPointer;
		}
	}
}

int main()
{
	setlocale(LC_ALL, "Russian");
	size_t firstArrayOfNumbs[maxSizeOfArray];
	size_t secondArrayOfNumbs[maxSizeOfArray];

	srand(time(nullptr));

	size_t sizeOfFirstArray = 0;
	size_t sizeOfSecondArray = 0;

	cout << "¬ведите n и k: ";
	cin >> sizeOfFirstArray >> sizeOfSecondArray;

	fillArray(firstArrayOfNumbs, sizeOfFirstArray+1);
	fillArray(secondArrayOfNumbs, sizeOfSecondArray+1);

	qSort(firstArrayOfNumbs, 1, sizeOfFirstArray+1);
	qSort(secondArrayOfNumbs, 1, sizeOfSecondArray+1);

	cout << "Ёлементы k, содержащиес€ в массиве:" << endl;

	bool thereAreElements = false;

	findSameElements(firstArrayOfNumbs, secondArrayOfNumbs, sizeOfFirstArray, sizeOfSecondArray, thereAreElements);

	if (!thereAreElements)
	{
		cout << "таких элементов не найдено.";
	}

	return 0;
}