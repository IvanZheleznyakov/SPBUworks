#include <iostream>
#include <fstream>
#include <string>

#include "hashFunctions.h"

using namespace std;

// Алгоритм Рабина-Карпа.
void rabinKarpAlgorithm(string someString, string substring, int hashOfSubstr, const int simpleNumb)
{
	int index = 0;
	string tempSubstr = someString.substr(0, substring.length());
	int hashOfTempSubstr = hashFunctionForString(tempSubstr, simpleNumb);
	while (index < someString.length() - substring.length() + 1)
	{
		if (hashOfTempSubstr == hashOfSubstr)
		{
			if (substring == tempSubstr)
			{
				cout << "Индекс первого вхождения подстроки в строку: " << index << endl;
				return;
			}
		}
		hashOfTempSubstr -= hashFunctionForChar(someString[index], tempSubstr.length(), simpleNumb);
		hashOfTempSubstr *= simpleNumb;
		hashOfTempSubstr += hashFunctionForChar(someString[index + substring.length()], 1, simpleNumb);
		tempSubstr.erase(0, 1);
		tempSubstr += someString[index + substring.length()];
		++index;
	}

	cout << "Подстрока не входит в строку." << endl;
}

void main()
{
	setlocale(LC_ALL, "Russian");

	string substring;
	cout << "Введите подстроку, которую Вы хотите найти: ";
	cin >> substring;

	const int simpleNumb = 67;

	int hashOfSubstr = hashFunctionForString(substring, simpleNumb);

	fstream input("string.txt");
	if (input.eof())
	{
		cout << "Файл пуст." << endl;
		input.close();
		return;
	}
	string someString;
	getline(input, someString);
	if (substring.length() > someString.length())
	{
		cout << "Подстрока больше данной строки." << endl;
		return;
	}

	input.close();

	rabinKarpAlgorithm(someString, substring, hashOfSubstr, simpleNumb);
}

// Мои тесты.
// Строка: abracadabra
// Подстрока: dabr
// Вывод: 6
// 
// Строка: smallString
// Подстрока: largeStringische
// Вывод: подстрока больше строки
// 
// Строка: IvanHi
// Подстрока: Hello
// Вывод: подстрока не найдена
// 