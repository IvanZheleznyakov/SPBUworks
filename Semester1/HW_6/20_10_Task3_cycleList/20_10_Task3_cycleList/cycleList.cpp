#include <iostream>
#include <algorithm>

using namespace std;

struct ListElement
{
	int value;
	ListElement *next;
};

struct List
{
	ListElement *head = nullptr;
};

int main()
{
	setlocale(LC_ALL, "Russian");

	int numberOfWarriors = -1;
	int deadWarrior = -1;

	while (numberOfWarriors <= 0 || deadWarrior <= 0)
	{
		cout << "������� ���������� ������: " << endl;
		cin >> numberOfWarriors;
		cout << "������� ������ ����� �������?" << endl;
		cin >> deadWarrior;

		if (numberOfWarriors <= 0 || deadWarrior <= 0)
		{
			cout << "������������ ����!" << endl;
		}
	}

	List * list = new List;

	for (int i = numberOfWarriors; i != 0; --i)
	{
		ListElement *listElement = new ListElement;
		listElement->value = i;
		listElement->next = list->head;
		list->head = listElement;
	}

	ListElement * listElement = list->head;

	while (listElement->next != nullptr)
	{
		listElement = listElement->next;
	}
	listElement->next = list->head;

	while (listElement != listElement->next)
	{
		for (int i = 0; i != deadWarrior - 1; ++i)
		{
			listElement = listElement->next;
		}
		ListElement * tempListElement = listElement->next->next;
		delete listElement->next;
		listElement->next = tempListElement;
	}

	cout << "����� ������� ��������� �����: " << listElement->value << endl;

	delete listElement;

	delete list;

	return 0;
}

//��� �����.
//������� ������: 
//11
//3
//�������� ������:
//7
//
//������� ������:
//5
//1
//�������� ������:
//5
//������� ������:
//1
//21
//�������� ������:
//1