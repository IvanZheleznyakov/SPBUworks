#pragma once

#include "list.h"

struct List;

struct ListElement;

// Создание списка.
List * createList();

// Создание массива списков.
List ** createArrayOfList(int size);

// Возвращение количества элементов в списке.
int numberOfElementsInList(List * list);

// Вернуть указатель на голову списка.
ListElement * pointerOnHead(List * list);

// Вернуть указатель на следующий элемент списка.
ListElement * pointerOnNextElement(ListElement * listElement);

// Вернуть значение элемента списка.
int valueElement(ListElement * listElement);

// Добавление элемента в список.
void addElementInList(List * list, int town);

// Удаление и возвращение удаленного элемента из списка.
int deleteElementFromList(List * list);

// Инверсия списка.
List * reverseList(List * list);

// Удаление списка.
void deleteList(List * list);

// Удаление массива списков.
void deleteArrayOfList(List ** arrayOfList, int size);