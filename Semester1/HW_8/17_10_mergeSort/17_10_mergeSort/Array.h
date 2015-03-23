#pragma once

struct Array;

// �������� �������.
Array * createLinked();

// ������� ����� ��������� � �������.
size_t numberOfElements(Array * array);

// ���������� ��������.
void addElement(Array * array, int value);

// �������� �������� �� �������.
int deleteElement(Array * array);

// ��������� ���������� �������� �������.
int headValue(Array * array);

// �������� �������.
Array * reverseLinked(Array * array);

// �������� �������.
void deleteLinked(Array * array);