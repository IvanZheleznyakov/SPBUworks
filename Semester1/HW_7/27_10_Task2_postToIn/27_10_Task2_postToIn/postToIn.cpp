#include <iostream>
#include <string>
#include <cstring>

#include "stack.h"

using namespace std;

int main()
{
	setlocale(LC_ALL, "Russian");

	const char plus = '+';
	const char minus = '-';
	const char multiplication = '*';
	const char division = '/';
	char symbol = ' ';

	Stack * stack = createStack();

	size_t countNumbers = 0;
	size_t countOperations = 0;

	bool isNotCorrect = false;

	cout << "Введите выражение и завершающий символ 'равно' ( = ): ";
	while (symbol != '=')
	{
		if (isNotCorrect)
		{
			break;
		}

		cin >> symbol;

		if (symbol != ' ' && symbol != '=')
			{
				if (symbol >= '0' && symbol <= '9')
				{
					stackPush(stack, symbol - '0');
					++countNumbers;
				}
				else
				{
					++countOperations;
					int secondNumber = stackPop(stack, isNotCorrect);
					int firstNumber = stackPop(stack, isNotCorrect);
					int tempExpression = 0;

					switch (symbol)
					{

					case plus:
					{
						tempExpression = firstNumber + secondNumber;
						stackPush(stack, tempExpression);
						break;
					}

					case minus:
					{
						tempExpression = firstNumber - secondNumber;
						stackPush(stack, tempExpression);
						break;
					}

					case multiplication:
					{
						tempExpression = firstNumber * secondNumber;
						stackPush(stack, tempExpression);
						break;
					}

					case division:
					{
						tempExpression = firstNumber / secondNumber;
						stackPush(stack, tempExpression);
						break;
					}

					default:
					{
						isNotCorrect = true;
						break;
					}
					}
			}
		}
	}

	if (countOperations + 1 == countNumbers && !isNotCorrect)
	{
		cout << "Значение выражения: " << stackPop(stack, isNotCorrect) << endl;
	}
	else
	{
		cout << "Некорректный ввод!" << endl;
	}

	deleteStack(stack);

	return 0;

}