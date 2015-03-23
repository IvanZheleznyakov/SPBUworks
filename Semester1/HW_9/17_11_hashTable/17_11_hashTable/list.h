#pragma once
#include <string>

struct List;

struct ListElement;

// �������� ������.
List * createList();

List ** createArrayOfList(int capacity);

// ����� ��������� � ������.
size_t numberOfElementsInList(List * list);

// ��������� �� ������ ������� ������.
ListElement * pointerOnFirstElement(List * list);
//
// ���������� ��������.
void addElement(List * list, std::string value);
//
// �������� � ����������� �������� �� ������.
void deleteElement(List * list);
//
// ������ ������� � ������.
std::string headValue(List * list);
//
//// �������������� ������.
//List * reverseList(List * list);

// �������� �����.
void deleteList(List * list);