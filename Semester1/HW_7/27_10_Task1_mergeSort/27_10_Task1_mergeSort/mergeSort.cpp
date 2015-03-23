#include <iostream>
#include <fstream>
#include <algorithm>
#include <string>

using namespace std;

struct RecordInBook
{
	size_t number;
	string name;
	RecordInBook * next = nullptr;
};

struct PhoneBook
{
	size_t numberOfRecords = 0;
	RecordInBook * head = nullptr;
};

// �������� ������ �� ������.
RecordInBook * deleteRecord(PhoneBook * phoneBook)
{
	RecordInBook *temp = phoneBook->head;
	phoneBook->head = phoneBook->head->next;
	--phoneBook->numberOfRecords;
	temp->next = nullptr;
	return temp;
}

// ������ ������ �� �����.
bool readRecords(PhoneBook * phoneBook)
{
	ifstream input("Text.txt");
	if (!input)
	{
		cout << "���� ����." << endl;
		return false;
	}
	else
	{
		while (!input.eof())
		{
			RecordInBook * recordInBook = new RecordInBook;
			input >> recordInBook->name;
			input >> recordInBook->number;
			recordInBook->next = phoneBook->head;
			phoneBook->head = recordInBook;
			++phoneBook->numberOfRecords;
		}

		input.close();
	}

	return true;
}

// ���������� ������ � ������.
void addRecord(PhoneBook * phoneBook, RecordInBook * recordInBook)
{
	recordInBook->next = phoneBook->head;
	phoneBook->head = recordInBook;
	++phoneBook->numberOfRecords;
}

// �������������� ������.
PhoneBook * reverseBook(PhoneBook * phoneBook)
{
	PhoneBook * tempBook = new PhoneBook;
	while (phoneBook->head != nullptr)
	{
		addRecord(tempBook, deleteRecord(phoneBook));
	}
	delete phoneBook;
	return tempBook;
}

// ��������� ���� �������.
bool compareRecords(PhoneBook * firstBook, PhoneBook * secondBook, bool isNumberSort)
{
	if (isNumberSort)
	{
		return (firstBook->head->number > secondBook->head->number);
	}

	return (firstBook->head->name > secondBook->head->name);
}

// ������� ���� ������� � ����.
PhoneBook * merge(PhoneBook * phoneBook, PhoneBook * tempBook, bool & isNumberSort)
{
	PhoneBook * sortBook = new PhoneBook;
	size_t sizeOfSortBook = phoneBook->numberOfRecords + tempBook->numberOfRecords;

	phoneBook = reverseBook(phoneBook);
	tempBook = reverseBook(tempBook);

	for (size_t i = 0; i != sizeOfSortBook; ++i)
	{
		if (phoneBook->numberOfRecords && tempBook->numberOfRecords)
		{
			if (compareRecords(phoneBook, tempBook, isNumberSort))
			{
				addRecord(sortBook, deleteRecord(phoneBook));
			}
			else
			{
				addRecord(sortBook, deleteRecord(tempBook));
			}
		}
		else if (phoneBook->numberOfRecords)
		{
			addRecord(sortBook, deleteRecord(phoneBook));
		}
		else
		{
			addRecord(sortBook, deleteRecord(tempBook));
		}
	}

	delete phoneBook;
	delete tempBook;

	return sortBook;
}

// ���������� ��������.
PhoneBook * mergeSort(PhoneBook * phoneBook, bool isNumberSort)
{
	if (phoneBook->numberOfRecords != 1)
	{
		PhoneBook * tempBook = new PhoneBook;
		size_t middle = phoneBook->numberOfRecords / 2;
		while (phoneBook->numberOfRecords > middle)
		{
			addRecord(tempBook, deleteRecord(phoneBook));
		}

		phoneBook = merge(mergeSort(phoneBook, isNumberSort), mergeSort(tempBook, isNumberSort), isNumberSort);

	}

	return phoneBook;
}

void showBook(PhoneBook * phoneBook)
{
	RecordInBook * showRecord = phoneBook->head;
	cout << "� ��� � ���� ����������: " << endl;
	while (showRecord != nullptr)
	{
		cout << showRecord->name << " " << showRecord->number << endl;
		showRecord = showRecord->next;
	}
}

void main()
{
	setlocale(LC_ALL, "Russian");

	PhoneBook * phoneBook = new PhoneBook;

	if (readRecords(phoneBook))
	{
		cout << "�������� �������� ���������� (0 - �� ������; 1 - �� �������): ";
		bool isNumberSort = false;
		cin >> isNumberSort;
		phoneBook = mergeSort(phoneBook, isNumberSort);
		showBook(phoneBook);
	}

	delete phoneBook;
}