#include <fstream>
#include <iostream>
#include <string>

using namespace std;

const size_t maxSizeOfBook = 100;

struct RecordInBook
{
	string name;
	size_t phoneNumber;
};

void addRecord(RecordInBook phoneBook[], size_t & numberOfRecords) // добавление записи в телефонную книгу
{
	cout << "Введите имя: " << endl;
	cin >> phoneBook[numberOfRecords].name;
	cout << "Введите телефон: " << endl;
	cin >> phoneBook[numberOfRecords].phoneNumber;
	++numberOfRecords;
}

size_t findNumber(RecordInBook phoneBook[], size_t numberOfRecords) // поиск номера контакта по имени и возвращение его
{									
	cout << "Введите имя, по которому вы хотите найти номер: " << endl;
	string name;
	cin >> name;
	for (size_t i = 0; i != numberOfRecords; ++i)
	{
		if (phoneBook[i].name == name)
		{
			return phoneBook[i].phoneNumber;
		}
	}
	return 0;
}

string findName(RecordInBook phoneBook[], size_t numberOfRecords) // поиск имени контакта по номеру и возвращение его
{
	cout << "Введите номер, по которому вы хотите найти имя: " << endl;
	size_t phoneNumber;
	cin >> phoneNumber;
	for (size_t i = 0; i != numberOfRecords; ++i)
	{
		if (phoneBook[i].phoneNumber == phoneNumber)
		{
			return phoneBook[i].name;
		}
	}
	return "";
}

void savePhoneBookInFile(RecordInBook phoneBook[], size_t numberOfRecords) // сохранение записей в файл
{
	ofstream output("TelephoneBook.txt", ios_base::trunc);
	for (size_t i = 0; i != numberOfRecords; ++i)
	{
		output << phoneBook[i].name << " " << phoneBook[i].phoneNumber << endl;
	}

	output.close();
}

int main()
{
	setlocale(LC_ALL, "Russian");

	RecordInBook phoneBook[maxSizeOfBook];

	string name;
	size_t phoneNumber;
	size_t numberOfRecords = 0;

	ifstream input("TelephoneBook.txt");
	while (input)
	{
		input >> name;
		if (name.size())
		{
			phoneBook[numberOfRecords].name = name;
			input >> phoneNumber;
			phoneBook[numberOfRecords].phoneNumber = phoneNumber;
			++numberOfRecords;
		}
	}

	input.close();

	int operation = -1;

	while (operation)
	{
		cout << "Какую операцию вы хотите выполнить?" << endl;
		cout << "0 - выйти" << endl;
		cout << "1 - добавить запись в телефонную книгу" << endl;
		cout << "2 - найти номер по имени" << endl;
		cout << "3 - найти имя по номеру телефона" << endl;
		cout << "4 - сохранить текущие данные в файл" << endl;
		cin >> operation;

		switch (operation)
		{
		case 0:
			break;
		case 1:
		{
			addRecord(phoneBook, numberOfRecords);
			break;
		}

		case 2:
		{
			int thisNumber = findNumber(phoneBook, numberOfRecords);
			if (thisNumber)
			{
				cout << "Номер этого контакта: " << thisNumber << endl;
			}
			else
			{
				cout << "Нет контакта с таким именем." << endl;
			}
			break;
		}

		case 3:
		{
			string thisName = findName(phoneBook, numberOfRecords);
			if (thisName != "")
			{
				cout << "Имя контакта с данным номером: " << thisName << endl;
			}
			else
			{
				cout << "Нет контакта с таким номером." << endl;
			}
			break;
		}

		case 4:
		{
			savePhoneBookInFile(phoneBook, numberOfRecords);
			break;
		}

		default:
		{
			cout << "Вы ввели некорректный номер операции." << endl;
			break;
		}
		}
	}
	return 0;
}