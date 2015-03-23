#include <iostream>
#include <string.h>
#include <ctime>
#include <cstdlib>
#include <algorithm>

using namespace std;

int const sizeOfArray = 50; // размер массива
int const rangeOfRandNumb = 25; // диапазон случайных чисел

void fillArray(int arrayOfNumbs[]) // функция, которая принимает массив и заполняет его случайными значениями
{
	for (int i = 1; i != sizeOfArray; i++)
	{
		arrayOfNumbs[i] = rand() % rangeOfRandNumb;
	}
}

void showArray(int arrayOfNumbs[]) // вывод элементов массива на экран
{
	for (int i = 1; i != sizeOfArray; i++)
	{
		cout << arrayOfNumbs[i] << endl;
	}
}

void insertSort(int arrayOfNumbs[], int aLeft, int aRight) // алгоритм сортировки вставками
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

int partition(int arrayOfNumbs[], int aLeft, int aRight) // функция нахождения разделителя
{
	int temporaryPivot = arrayOfNumbs[aLeft]; // элемент, являющийся разделителем
	int i = aLeft; 
	int j = i; // указатель, который в конце функции будет указывать на элемент массива, в который
									// нужно будет переместить первый элемент массива
	for (i = aLeft + 1; i != aRight+1; ++i) // запускаем цикл, после которого кусок массива будет преобразован следующим
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

void qSort(int arrayOfNumbs[], int aLeft, int aRight) // алгоритм быстрой сортировки
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

//Мои тесты.
//Входные данные: 
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
//Выходные данные:
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
//Входные данные:
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
//Выходные данные:
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
//Входные данные: 
//1
//0
//
//Выходные данные:
//0
//1