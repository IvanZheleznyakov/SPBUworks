#include <iostream>
#include <algorithm>

using namespace std;

struct ListElement
{
	int value = 0;
	ListElement *next;
};

struct List
{
	ListElement *head = nullptr;
};

void addElement(List * list)
{
	int value;
	cout << "������� �������� ������������ ��������." << endl;
	cin >> value;

	ListElement * listElement = new ListElement;
	listElement->value = value;
	listElement->next = list->head;
	list->head = listElement;
	while (listElement->next != nullptr && listElement->value > listElement->next->value)
	{
		swap(listElement->value, listElement->next->value);
		listElement = listElement->next;
	}
}

void deleteElement(List * list)
{
	if (list->head == nullptr)
	{
		cout << "������ ����!" << endl;
		return;
	}
	int value = 0;
	cout << "������� �������� ���������� ��������." << endl;
	cin >> value;

	if (list->head->value == value)
	{
		ListElement *temp = list->head->next;
		delete list->head;
		list->head = temp;
	}
	else
	{
		ListElement * listElement = list->head;
		while (listElement->next->value != value)
		{
			listElement = listElement->next;
			if (listElement->next == nullptr)
			{
				cout << "�������� � ����� ��������� ��� � ������!" << endl;
				return;
			}
		}
		ListElement * tempListElement = listElement->next->next;
		delete listElement->next;
		listElement->next = tempListElement;
//		tempListElement = listElement->next;
//		listElement->next = tempListElement->next;
//		delete tempListElement;
	}
}

void showList(List * list)
{
	if (list->head == nullptr)
	{
		cout << "������ ����!" << endl;
		return;
	}
	ListElement * listElement = list->head;
	while (listElement != nullptr)
	{
		cout << listElement->value << " ";
		listElement = listElement->next;
	}
}

int main()
{
	setlocale(LC_ALL, "Russian");

	List * list = new List;
	int operation = -1;

	while (operation)
	{
		cout << "������� ����� ��������:" << endl;
		cout << "0 - �����" << endl;
		cout << "1 - �������� �������� � ������" << endl;
		cout << "2 - ������� �������� �� ������" << endl;
		cout << "3 - ����������� ������" << endl;
		cin >> operation;

		switch (operation)
		{
		case 0:
			break;
		case 1:
		{
			addElement(list);
			break;
		}
		case 2:
		{
			deleteElement(list);
			break;
		}
		case 3:
		{
			showList(list);
			break;
		}
		default:
		{
			cout << "������������ ���� ��������." << endl;
			break;
		}
		}
	}

	ListElement * listElement = list->head;
	while (listElement != nullptr)
	{
		ListElement * temp = list->head->next;
		delete list->head;
		list->head = temp;
	}

	delete list;

	return 0;
}