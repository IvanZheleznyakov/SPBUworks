#include <iostream>
#include <algorithm>

using namespace std;

void shellSort(int arrayOfNumbs[], int sizeOfArray) // алгоритм сортировки Шелла
{
	int step = sizeOfArray / 2;

	while (step > 0)
	{
		for (size_t i = 0; i != (sizeOfArray - step); i++)
		{
			int j = i;
			while (j >= 0 && arrayOfNumbs[j] > arrayOfNumbs[j + step])
			{
				swap(arrayOfNumbs[j], arrayOfNumbs[j + step]);
				--j;
			}
		}
		step /= 2;
	}
}

int main()
{
	setlocale(LC_ALL, "Russian");

	int sizeOfArray = 0;
	cout << "Введите размер массива: " << endl;
	cin >> sizeOfArray;
	while (sizeOfArray <= 0)
	{
		cout << "Некорректный ввод. Введите размер массива еще раз: " << endl;
		cin >> sizeOfArray;
	}

	int *arrayOfNumbs = new int[sizeOfArray];
	
	cout << "Вводите элементы массива: " << endl;

	for (size_t i = 0; i != sizeOfArray; i++)
	{
		cin >> arrayOfNumbs[i];
	}
	
	shellSort(arrayOfNumbs, sizeOfArray);

	cout << "Отсортированный массив: " << endl;
	for (int i = 0; i != sizeOfArray; i++)
	{
		cout << arrayOfNumbs[i] << endl;
	}

	delete arrayOfNumbs;

	return 0;

}

//Мои тесты.
//Входные данные:
//7
//-1
//0
//2
//-30
//256
//1
//0
//Выходные данные:
//-30
//-1
//0
//0
//1
//2
//256