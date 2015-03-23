// Task7.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <iostream>

using namespace std;

int main()
{
	char bracket = 0;
	int check = 0;

	cout << "Enter string (last element is 'F'): ";

	while ((bracket != 'F') && (check != -1)) {
		cin >> bracket;
		if (bracket == '(') {
			++check;
		}
		else if (bracket == ')') {
			--check;
		}
	}

	if (check == 0) {
		cout << "All is right!" << endl;
	}
	else {
		cout << "Error!" << endl;
	}

	return 0;
}

