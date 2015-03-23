#include <iostream>
#include <string>

#include "stack.h"

using namespace std;

void main()
{
	setlocale(LC_ALL, "Russian");

	cout << "������� ������������������ ������: " << endl;
	string brackets;
	cin >> brackets;

	Stack * stack = createStack();
	bool stackIsEmpty = false;

	for (size_t i = 0; i != brackets.size(); ++i)
	{
		if (brackets[i] == '(' || brackets[i] == '[' || brackets[i] == '{')
		{
			stackPush(stack, brackets[i]);
		}
		else if (brackets[i] == ')' || brackets[i] == ']' || brackets[i] == '}')
		{
			char openBracket = stackPop(stack, stackIsEmpty);
			if (stackIsEmpty || (abs(brackets[i] - openBracket) > 2))
			{
				cout << "������ ������ �� ��������." << endl;
				deleteStack(stack);
				return;
			}
		}
		else
		{
			cout << "������������ ����." << endl;
			deleteStack(stack);
			return;
		}
	}

	char test = stackPop(stack, stackIsEmpty);
	if (stackIsEmpty)
	{
		cout << "������ ������ ��������." << endl;
		deleteStack(stack);
		return;
	}

	cout << "������ ������ �� ��������." << endl;
	deleteStack(stack);

}