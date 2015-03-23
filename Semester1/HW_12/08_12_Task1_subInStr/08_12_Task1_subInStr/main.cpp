#include <iostream>
#include <fstream>
#include <string>

#include "hashFunctions.h"

using namespace std;

// �������� ������-�����.
void rabinKarpAlgorithm(string someString, string substring, int hashOfSubstr, const int simpleNumb)
{
	int index = 0;
	string tempSubstr = someString.substr(0, substring.length());
	int hashOfTempSubstr = hashFunctionForString(tempSubstr, simpleNumb);
	while (index < someString.length() - substring.length() + 1)
	{
		if (hashOfTempSubstr == hashOfSubstr)
		{
			if (substring == tempSubstr)
			{
				cout << "������ ������� ��������� ��������� � ������: " << index << endl;
				return;
			}
		}
		hashOfTempSubstr -= hashFunctionForChar(someString[index], tempSubstr.length(), simpleNumb);
		hashOfTempSubstr *= simpleNumb;
		hashOfTempSubstr += hashFunctionForChar(someString[index + substring.length()], 1, simpleNumb);
		tempSubstr.erase(0, 1);
		tempSubstr += someString[index + substring.length()];
		++index;
	}

	cout << "��������� �� ������ � ������." << endl;
}

void main()
{
	setlocale(LC_ALL, "Russian");

	string substring;
	cout << "������� ���������, ������� �� ������ �����: ";
	cin >> substring;

	const int simpleNumb = 67;

	int hashOfSubstr = hashFunctionForString(substring, simpleNumb);

	fstream input("string.txt");
	if (input.eof())
	{
		cout << "���� ����." << endl;
		input.close();
		return;
	}
	string someString;
	getline(input, someString);
	if (substring.length() > someString.length())
	{
		cout << "��������� ������ ������ ������." << endl;
		return;
	}

	input.close();

	rabinKarpAlgorithm(someString, substring, hashOfSubstr, simpleNumb);
}

// ��� �����.
// ������: abracadabra
// ���������: dabr
// �����: 6
// 
// ������: smallString
// ���������: largeStringische
// �����: ��������� ������ ������
// 
// ������: IvanHi
// ���������: Hello
// �����: ��������� �� �������
// 