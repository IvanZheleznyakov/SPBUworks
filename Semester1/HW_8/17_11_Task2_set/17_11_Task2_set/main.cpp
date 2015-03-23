#include <iostream>

#include "tree.h"

using namespace std;

void operationList()
{
	cout << "Введите номер операции: " << endl;
	cout << "0 - выйти;" << endl;
	cout << "1 - добавить элемент во множество;" << endl;
	cout << "2 - удалить элемент из множества;" << endl;
	cout << "3 - проверить, является ли число элементом множества;" << endl;
	cout << "4 - распечатать элементы множества." << endl;
}

void main()
{
	setlocale(LC_ALL, "Russian");

	Tree * tree = createTree();

	int operation = -1;

	while (operation)
	{
		operationList();
		cin >> operation;

		switch (operation)
		{
		case 0:
			break;
		case 1:
		{
			cout << "Введите значение добавляемого элемента: " << endl;
			int addedValue = 0;
			cin >> addedValue;
			addElement(tree, addedValue);

			break;
		}
		case 2:
		{
			cout << "Введите значение удаляемого элемента: " << endl;
			int deletedValue = 0;
			cin >> deletedValue;
			deleteElement(tree, deletedValue);

			break;
		}
		case 3:
		{
			cout << "Введите число для проверки: " << endl;
			int checkedValue = 0;
			cin >> checkedValue;
			if (checkElement(tree, checkedValue))
			{
				cout << "Этот элемент находится во множестве." << endl;
			}
			else
			{
				cout << "Этот элемент не находится во множестве." << endl;
			}

			break;
		}
		case 4:
		{
			cout << "0 - сортировка по возрастанию;" << endl;
			cout << "1 - сортировка по убыванию." << endl;
			bool sortByDescending = false;
			cin >> sortByDescending;
			printTree(tree, sortByDescending);

			break;
		}
		default:
		{
			cout << "Некорректный номер операции." << endl;

			break;
		}
		}
	}

	deleteTree(tree);
}