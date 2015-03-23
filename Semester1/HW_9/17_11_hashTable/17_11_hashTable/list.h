#pragma once
#include <string>

struct List;

struct ListElement;

// Создание списка.
List * createList();

List ** createArrayOfList(int capacity);

// Число элементов в списке.
size_t numberOfElementsInList(List * list);

// Указатель на первый элемент списка.
ListElement * pointerOnFirstElement(List * list);
//
// Добавление элемента.
void addElement(List * list, std::string value);
//
// Удаление и возвращение элемента из списка.
void deleteElement(List * list);
//
// Первый элемент в списке.
std::string headValue(List * list);
//
//// Инвертирование списка.
//List * reverseList(List * list);

// Удаление спика.
void deleteList(List * list);