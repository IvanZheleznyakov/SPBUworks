#include <iostream>
#include <fstream>
#include <string>

#include "tree.h"
#include "expression.h"

using namespace std;

void main()
{
	setlocale(LC_ALL, "Russian");

	Tree * tree = createTree();

	ifstream input("expression.txt");
	while (!input.eof())
	{
		string operatorOrOperand;
		input >> operatorOrOperand;
		if (operatorOrOperand != "(" && operatorOrOperand != ")")
		{
			addElement(tree, operatorOrOperand);
		}
	}
	input.close();

	cout << "Выражение: " << endl;
	printTree(tree);
	cout << endl;

	cout << "Значение выражения: " << endl;
	cout << countExpression(tree) << endl;

	deleteTree(tree);
}