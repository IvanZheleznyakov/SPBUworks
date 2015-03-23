// Task8.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <iostream>

using namespace std;

int const sizeOfString = 100;

bool checkChar(char firstString[], char secondString[], int firstChar, int secondChar)
{
	if (firstString[firstChar] == secondString[secondChar]) 
	{
		if (secondChar == strlen(secondString) - 1) 
		{
			return true;
		}
		else return (checkChar(firstString, secondString, firstChar + 1, secondChar + 1));
	} 
	else  
	{
		return false; 
	}
}

int main()
{
	char firstString[sizeOfString]; 
	char secondString[sizeOfString];

	cout << "Enter s and s1: " << endl;
	cin >> firstString >> secondString;
	cin.ignore();

	int lengthS = strlen(firstString) - 1;
	int lengthS1 = strlen(secondString) - 1;

	int count = 0;

	for (int i = 0; i < (lengthS - lengthS1 + 1); i++) {
		int j = 0;
		if (checkChar(firstString, secondString, i, j)) {
			++count;
		}
	}

	cout << "Answer: " << count << endl;

	return 0;
}