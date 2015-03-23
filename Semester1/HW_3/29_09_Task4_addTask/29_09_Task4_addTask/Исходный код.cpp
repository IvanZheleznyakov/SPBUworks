#include <iostream>
#include <string>

using namespace std;

int main()
{
	setlocale(LC_ALL, "Russian");

	int helpArray[10] {0};
	string number;

	cout << "Введите число:" << endl;
	cin >> number;
	if (number[0] == '0')
	{
		cout << "Некорректный ввод!" << endl;
		return 0;
	}

	for (size_t i = 0; i != number.size(); ++i)
	{
		if (number[i] < '0' || number[i] > '9')
		{
			cout << "Некорректный ввод!" << endl;
			return 0;
		}
		++helpArray[number[i] - '0'];
	}

	cout << "Наименьшее число из цифр данного числа: " << endl;
	for (size_t i = 1; i != 10; ++i)
	{
		if (helpArray[i])
		{
			cout << i;
			--helpArray[i];
			break;
		}
	}

	for (size_t i = 0; i != 10; ++i)
	{
		while (helpArray[i])
		{
			cout << i;
			--helpArray[i];
		}
	}
	cout << endl;

	return 0;
}

//Мои тесты.
//Входные данные :
//30201
//
//Выходные данные :
//10023
//___________________
//Входные данные :
//-23
//
//Выходные данные :
//Ошибка
//___________________
//Входные данные :
//023
//
//Выходные данные :
//Ошибка
//___________________
//Входные данные :
//Twenty three
//
//Выходные данные :
//Ошибка