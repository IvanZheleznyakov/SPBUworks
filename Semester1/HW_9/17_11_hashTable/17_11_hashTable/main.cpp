#include <fstream>
#include <string>
#include <iostream>

#include "hashTable.h"

using namespace std;

void main()
{
	setlocale(LC_ALL, "Russian");

	HashTable * hashTable = createHashTable();

	ifstream input("text.txt");
	while (!input.eof())
	{
		string word;
		input >> word;
		addHashElement(hashTable, word);
	}
	input.close();

	printHashTable(hashTable);

	deleteHashTable(hashTable);

}

// ��� �����:
// ����:
// haha al haha net al yer haha rey
// �����:
// 2 ���(-�) ����������� ����� al
// 1 ���(-�) ����������� ����� net
// 1 ���(-�) ����������� ����� rey
// 1 ���(-�) ����������� ����� yer
// 3 ���(-�) ����������� ����� haha

