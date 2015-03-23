#pragma once
#include <string>

struct HashTable;

// Созданий хэш-таблицы.
HashTable * createHashTable();

// Вернуть количество ячеек в хэш-таблице.
const int capacityOfHashTable(HashTable * hashTable);

// Добавить элемент в хэш-таблицу.
void addHashElement(HashTable * hashTable, std::string value);

// Распечатать хэш-таблицу.
void printHashTable(HashTable * hashTable);

// Удаление хэш-таблицы.
void deleteHashTable(HashTable * hashTable);