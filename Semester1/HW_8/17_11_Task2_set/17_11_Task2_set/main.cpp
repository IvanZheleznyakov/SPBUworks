#include <iostream>

#include "tree.h"

using namespace std;

void operationList()
{
	cout << "������� ����� ��������: " << endl;
	cout << "0 - �����;" << endl;
	cout << "1 - �������� ������� �� ���������;" << endl;
	cout << "2 - ������� ������� �� ���������;" << endl;
	cout << "3 - ���������, �������� �� ����� ��������� ���������;" << endl;
	cout << "4 - ����������� �������� ���������." << endl;
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
			cout << "������� �������� ������������ ��������: " << endl;
			int addedValue = 0;
			cin >> addedValue;
			addElement(tree, addedValue);

			break;
		}
		case 2:
		{
			cout << "������� �������� ���������� ��������: " << endl;
			int deletedValue = 0;
			cin >> deletedValue;
			deleteElement(tree, deletedValue);

			break;
		}
		case 3:
		{
			cout << "������� ����� ��� ��������: " << endl;
			int checkedValue = 0;
			cin >> checkedValue;
			if (checkElement(tree, checkedValue))
			{
				cout << "���� ������� ��������� �� ���������." << endl;
			}
			else
			{
				cout << "���� ������� �� ��������� �� ���������." << endl;
			}

			break;
		}
		case 4:
		{
			cout << "0 - ���������� �� �����������;" << endl;
			cout << "1 - ���������� �� ��������." << endl;
			bool sortByDescending = false;
			cin >> sortByDescending;
			printTree(tree, sortByDescending);

			break;
		}
		default:
		{
			cout << "������������ ����� ��������." << endl;

			break;
		}
		}
	}

	deleteTree(tree);
}