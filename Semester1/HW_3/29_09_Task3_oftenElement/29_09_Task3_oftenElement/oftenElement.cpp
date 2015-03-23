#include <iostream>
#include <string.h>
#include <ctime>
#include <cstdlib>
#include <algorithm>

using namespace std;

const size_t sizeOfArray = 7; // размер массива
const size_t rangeOfRandNumb = 5; // диапазон случайных чисел

void fillArray(size_t arrayOfNumbs[]) // функция, которая принимает массив и заполняет его случайными значениями
{
	for (size_t i = 0; i != sizeOfArray; i++)
	{
		arrayOfNumbs[i] = rand() % rangeOfRandNumb;
	}
}

void showArray(size_t arrayOfNumbs[]) // вывод элементов массива на экран
{
	for (size_t i = 0; i != sizeOfArray; i++)
	{
		cout << arrayOfNumbs[i] << endl;
	}
}

void insertSort(size_t arrayOfNumbs[], size_t aLeft, size_t aRight) // алгоритм сортировки вставками
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

size_t partition(size_t arrayOfNumbs[], size_t aLeft, size_t aRight) // функция нахождения разделителя
{
	size_t temporaryPivot = arrayOfNumbs[aLeft]; // элемент, являющийся разделителем
	size_t i = aLeft;
	size_t j = i; // указатель, который в конце функции будет указывать на элемент массива, в который
	// нужно будет переместить первый элемент массива
	for (i = aLeft; i != aRight; ++i) // запускаем цикл, после которого кусок массива будет преобразован следующим
	{                                              // образом: для любого k от aLeft до j элемент с индексом k будет меньше
		if (arrayOfNumbs[i] <= temporaryPivot)            // либо равен первого элемента, а для любого k от j+1 до i
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

size_t oftenElement(size_t arrayOfNumbs[]) // функция, возвращающая наиболее часто встречающийся элемент
{
	size_t elementsInARow = 0;
	size_t maxElementsInARow = 0;
	size_t temporaryOftenElement = arrayOfNumbs[0];
	for (size_t i = 1; i != sizeOfArray; ++i)
	{
		if (arrayOfNumbs[i] == arrayOfNumbs[i - 1])      // если два стоящих рядом элемента равны, то увеличиваем
		{														// счетчик подряд идущих равных элементов 
			++elementsInARow;
			if (i == sizeOfArray - 1 && elementsInARow > maxElementsInARow)      
			{												
				maxElementsInARow = elementsInARow;           
				temporaryOftenElement = arrayOfNumbs[i - 1];
			}
		}
		else
		{
			if (elementsInARow > maxElementsInARow)      // если же элементы не равны, сравниваем количество идущих до
			{												// этого элементов подряд с максимальным количеством элементов,
				maxElementsInARow = elementsInARow;           // стоящих рядом
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

	cout << "Массив:" << endl;
	fillArray(arrayOfNumbs);
	//for (int i = 0; i != sizeOfArray; ++i)
	//{
	//	cin >> arrayOfNumbs[i];
	//}
	showArray(arrayOfNumbs);

	qSort(arrayOfNumbs, 0, sizeOfArray);

	showArray(arrayOfNumbs);

	cout << "Наиболее часто встречающийся элемент: " << oftenElement(arrayOfNumbs) << endl;

	return 0;
}

//Мои тесты.
//Входные данные :
//1 4 4 5 3 4 7 5 3 5 3 3 3 3 5 6 7 6 5 7 7 7 8 5 3 3 3 3 7
//Выходные данные :
//3
//_________
//
//Входные данные :
//1 2 1 1 2 2
//Выходные данные :
//1