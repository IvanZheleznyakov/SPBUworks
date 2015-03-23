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

// ћои тесты:
// ¬вод:
// haha al haha net al yer haha rey
// ¬ывод:
// 2 раз(-а) встречаетс€ слово al
// 1 раз(-а) встречаетс€ слово net
// 1 раз(-а) встречаетс€ слово rey
// 1 раз(-а) встречаетс€ слово yer
// 3 раз(-а) встречаетс€ слово haha

