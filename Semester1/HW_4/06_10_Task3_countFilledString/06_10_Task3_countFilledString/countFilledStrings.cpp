#include <string>
#include <string.h>
#include <fstream>
#include <iostream>

using namespace std;

int main()
{
	setlocale(LC_ALL, "Russian");

	int countNotEmptyStrings = 0; // ���������� �������� �����
	ifstream input("someStrings.txt");
	while (input)
	{
		string stringFromFile;
		bool foundNotSpaceAndNotTab = false; 
		getline(input, stringFromFile); // ������ ������ �� �����
		if (stringFromFile.size())      // ���� ������ ������ �� ����� ���� (�.�. � ������ ���� �������), ��
		{
			for (size_t i = 0; i != stringFromFile.size(); ++i) // ������� �� ������� ���� ������
			{
				if (stringFromFile[i] != ' ' && stringFromFile[i] != '\t')  // ���� ������� ������, �������� �� ������� �
				{																// ������� ���������, ��
					foundNotSpaceAndNotTab = true;									// �������� ���
					break;																// � ������� �� �����
				}
			}
		}
		
		if (foundNotSpaceAndNotTab) // ���� �� ����� ������, �������� �� ������� � ������� ���������, ��
		{
			++countNotEmptyStrings; // ����������� ������� �������� �����
		}
	}

	input.close();

	cout << "���������� �������� ����� � �����: " << countNotEmptyStrings << endl;

	return 0;
}

// ��� �����.
// ������� ������:
//hello Yuriy
//kak.dela ?
//
//haha
//
//love c++
//
//hochu kushat'   
//end	.
// �������� ������:
// 6
//___________
// ������� ������:
//			
//    
//				
//				
// �������� ������:
// 0