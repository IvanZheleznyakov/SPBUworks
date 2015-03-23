#pragma once

struct Array;

// Создание массива.
Array * createLinked();

// Текущее число элементов в массиве.
size_t numberOfElements(Array * array);

// Добавление элемента.
void addElement(Array * array, int value);

// Удаление элемента из массива.
int deleteElement(Array * array);

// Получение последнего элемента массива.
int headValue(Array * array);

// Инверсия массива.
Array * reverseLinked(Array * array);

// Удаление массива.
void deleteLinked(Array * array);