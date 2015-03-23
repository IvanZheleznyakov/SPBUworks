#include <iostream>
#include <string.h>
#include <ctime>
#include <cstdlib>

using namespace std;

int const sizeOfArray = 30; // размер изначального массива
int const rangeOfRandNumb = 25; // диапазон чисел в массиве

void fillArray(int arrayOfNumbs[]) // функция, которая принимает массив и заполняет его случайными значениями
{
	for (int i = 0; i < sizeOfArray; i++)
	{
		arrayOfNumbs[i] = rand() % rangeOfRandNumb;
	}
}

void showArray(int arrayOfNumbs[]) // вывод элементов массива на экран
{
	for (int i = 0; i < sizeOfArray; i++)
	{
		cout << arrayOfNumbs[i] << endl;
	}
}

int findOftenElement(int arrayOfNumbs[]) // функция нахождения наиболее часто встечающегося элемента в массиве
{
	int helpArray[rangeOfRandNumb] = {0}; // вспомогательный массив
	int oftenElement = 0;                  
	int countFrequency = 0;               // переменная, содержащая временну наибольшую частоту элемента в массиве

	for (int i = 0; i != sizeOfArray; ++i)     // идем по всему массиву
	{
		++helpArray[arrayOfNumbs[i]];          // увеличиваем индекс элемента вспомогательного массива,
													// равный элементу изначального массива
		if (helpArray[arrayOfNumbs[i]] > countFrequency)     // если элемент встречается больше раз, чем временная 		
		{														// частота, то
			++countFrequency;									// увеличиваем максимальную частоту на единицу
			oftenElement = arrayOfNumbs[i];						// и запоминаем текущий элемент
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