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

void addRecord(RecordInBook phoneBook[], size_t & numberOfRecords) // ���������� ������ � ���������� �����
{
	cout << "������� ���: " << endl;
	cin >> phoneBook[numberOfRecords].name;
	cout << "������� �������: " << endl;
	cin >> phoneBook[numberOfRecords].phoneNumber;
	++numberOfRecords;
}

size_t findNumber(RecordInBook phoneBook[], size_t numberOfRecords) // ����� ������ �������� �� ����� � ����������� ���
{									
	cout << "������� ���, �� �������� �� ������ ����� �����: " << endl;
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

string findName(RecordInBook phoneBook[], size_t numberOfRecords) // ����� ����� �������� �� ������ � ����������� ���
{
	cout << "������� �����, �� �������� �� ������ ����� ���: " << endl;
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

void savePhoneBookInFile(RecordInBook phoneBook[], size_t numberOfRecords) // ���������� ������� � ����
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
		cout << "����� �������� �� ������ ���������?" << endl;
		cout << "0 - �����" << endl;
		cout << "1 - �������� ������ � ���������� �����" << endl;
		cout << "2 - ����� ����� �� �����" << endl;
		cout << "3 - ����� ��� �� ������ ��������" << endl;
		cout << "4 - ��������� ������� ������ � ����" << endl;
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
				cout << "����� ����� ��������: " << thisNumber << endl;
			}
			else
			{
				cout << "��� �������� � ����� ������." << endl;
			}
			break;
		}

		case 3:
		{
			string thisName = findName(phoneBook, numberOfRecords);
			if (thisName != "")
			{
				cout << "��� �������� � ������ �������: " << thisName << endl;
			}
			else
			{
				cout << "��� �������� � ����� �������." << endl;
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
			cout << "�� ����� ������������ ����� ��������." << endl;
			break;
		}
		}
	}
	return 0;
}