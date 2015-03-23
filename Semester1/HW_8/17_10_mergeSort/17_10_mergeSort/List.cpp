#include "List.h"

struct ListElement
{
	int value = 0;
	ListElement * next = nullptr;
};

struct List
{
	size_t numberOfElements = 0;
	ListElement * head = nullptr;
};

List * createLinked()
{
	List * list = new List;
	return list;
}

size_t numberOfElements(List * list)
{
	return list->numberOfElements;
}

void addElement(List * list, int value)
{
	ListElement * listElement = new ListElement;
	listElement->value = value;
	listElement->next = list->head;
	list->head = listElement;
	++list->numberOfElements;
}

int deleteElement(List * list)
{
	int tempValue = list->head->value;
	ListElement *temp = list->head;
	list->head = list->head->next;
	--list->numberOfElements;
	temp->next = nullptr;
	return tempValue;
}

int headValue(List * list)
{
	return list->head->value;
}

List * reverseLinked(List * list)
{
	List * tempList = new List;
	while (list->head != nullptr)
	{
		addElement(tempList, deleteElement(list));
	}
	delete list;
	return tempList;
}

void deleteLinked(List * list)
{
	while (list->head != nullptr)
	{
		int temp = deleteElement(list);
	}

	delete list;
}