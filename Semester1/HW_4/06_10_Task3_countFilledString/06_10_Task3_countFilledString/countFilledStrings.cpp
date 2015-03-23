#include <string>
#include <string.h>
#include <fstream>
#include <iostream>

using namespace std;

int main()
{
	setlocale(LC_ALL, "Russian");

	int countNotEmptyStrings = 0; // количество непустых строк
	ifstream input("someStrings.txt");
	while (input)
	{
		string stringFromFile;
		bool foundNotSpaceAndNotTab = false; 
		getline(input, stringFromFile); // читаем строку из файла
		if (stringFromFile.size())      // если размер строки не равен нулю (т.е. в строке есть символы), то
		{
			for (size_t i = 0; i != stringFromFile.size(); ++i) // смотрим на символы этой строки
			{
				if (stringFromFile[i] != ' ' && stringFromFile[i] != '\t')  // если находим символ, отличный от пробела и
				{																// символа табуляции, то
					foundNotSpaceAndNotTab = true;									// помечаем это
					break;																// и выходим из цикла
				}
			}
		}
		
		if (foundNotSpaceAndNotTab) // если мы нашли символ, отличный от пробела и символа табуляции, то
		{
			++countNotEmptyStrings; // увеличиваем счетчик непустых строк
		}
	}

	input.close();

	cout << "Количество непустых строк в файле: " << countNotEmptyStrings << endl;

	return 0;
}

// Мои тесты.
// Входные данные:
//hello Yuriy
//kak.dela ?
//
//haha
//
//love c++
//
//hochu kushat'   
//end	.
// Выходные данные:
// 6
//___________
// Входные данные:
//			
//    
//				
//				
// Выходные данные:
// 0