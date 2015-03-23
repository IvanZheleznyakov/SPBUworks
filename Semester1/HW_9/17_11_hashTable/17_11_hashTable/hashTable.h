#pragma once
#include <string>

struct HashTable;

// �������� ���-�������.
HashTable * createHashTable();

// ������� ���������� ����� � ���-�������.
const int capacityOfHashTable(HashTable * hashTable);

// �������� ������� � ���-�������.
void addHashElement(HashTable * hashTable, std::string value);

// ����������� ���-�������.
void printHashTable(HashTable * hashTable);

// �������� ���-�������.
void deleteHashTable(HashTable * hashTable);