#include <iostream>

#include "stack.h"

using namespace std;

void main()
{
	setlocale(LC_ALL, "Russian");

	const char plus = '+';
	const char minus = '-';
	const char multiplication = '*';
	const char division = '/';
	char symbol = ' ';

	Stack * stackOutput = createStack();
	Stack * stackOperations = createStack();

	size_t countNumbers = 0;
	size_t countOperations = 0;
	int bracketBalance = 0;

	bool isNotCorrect = false;

	cout << "Введите выражение и завершающий символ 'равно' ( = ): ";
	while (symbol != '=')
	{
		cin >> symbol;
		if (symbol != '=')
		{
			if (symbol >= '0' && symbol <= '9')
			{
				++countNumbers;
				stackPush(stackOutput, symbol);
			}
			else if (symbol == plus || symbol == minus)
			{
				++countOperations;
				while (!stackIsEmpty(stackOperations) && (stackHeadSymbol(stackOperations) == multiplication || stackHeadSymbol(stackOperations) == division))
				{
					stackPush(stackOutput, stackPop(stackOperations, isNotCorrect));
					if (isNotCorrect)
					{
						incorrectInput(stackOutput, stackOperations);
						return;
					}
				}

				stackPush(stackOperations, symbol);
			}
			else if (symbol == multiplication || symbol == division)
			{
				++countOperations;
				stackPush(stackOperations, symbol);
			}
			else if (symbol == '(')
			{
				++bracketBalance;
				stackPush(stackOperations, symbol);
			}
			else if (symbol == ')')
			{
				--bracketBalance;
				while (stackHeadSymbol(stackOperations) != '(')
				{
					stackPush(stackOutput, stackPop(stackOperations, isNotCorrect));
					if (stackIsEmpty(stackOperations))
					{
						incorrectInput(stackOutput, stackOperations);
						return;
					}
				}
				char oddOpenBracket = stackPop(stackOperations, isNotCorrect);
			}
			else
			{
				incorrectInput(stackOutput, stackOperations);
				return;
			}
		}
	}

	if ((countNumbers != countOperations + 1) || bracketBalance)
	{
		incorrectInput(stackOutput, stackOperations);
		return;
	}

	while (!stackIsEmpty(stackOperations))
	{
		stackPush(stackOutput, stackPop(stackOperations, isNotCorrect));
	}

	deleteStack(stackOperations);

	stackOutput = reverseStack(stackOutput);

	while (!stackIsEmpty(stackOutput))
	{
		cout << stackPop(stackOutput, isNotCorrect) << " ";
	}

	deleteStack(stackOutput);
}

// Мои тесты.
//Входные данные:
//1+(2+3)*4+5*6-9
//Выходные данные:
//1 2 3 + 4 * 5 6 * 9 - + +
//
//Входные данные:
//2*(3-1)/2+9
//Выходные данные:
//2 3 1 - 2 / * 9 +
//
//Входные данные:
//2*(3-1)**2
//Выходные данные:
//Некорректный ввод
//
//Входные данные:
//(2*2)(9-1)-3)
//Выходные данные:
//Некорректный ввод