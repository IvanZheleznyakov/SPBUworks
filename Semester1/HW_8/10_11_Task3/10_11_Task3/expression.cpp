#include <string>

//#include "stack.h"
#include "expression.h"
#include "tree.h"

using namespace std;

//struct TreeElement
//{
//	string value;
//	TreeElement *left = nullptr;
//	TreeElement *right = nullptr;
//};
//
//struct Tree
//{
//	TreeElement *head = nullptr;
//};

int stringToInt(string number)
{
	int result = 0;
	for (size_t i = 0; i != number.size(); ++i)
	{
		int temp = static_cast<int>(number[i] - '0');
		for (size_t k = i; k != 0; --k)
		{
			temp *= 10;
		}
		result += temp;
	}

	return result;
}

//void doSomethingWithElement(string operatorOrOperand, Stack * stack)
//{
//	const string plus = "+";
//	const string minus = "-";
//	const string multiplication = "*";
//	const string division = "/";
//
//	if (operatorOrOperand == plus || operatorOrOperand == minus || operatorOrOperand == multiplication || operatorOrOperand == division)
//	{
//		int secondNumber = stackPop(stack);
//		int firstNumber = stackPop(stack);
//		int tempExpression = 0;
//
//		if (operatorOrOperand == plus)
//		{
//			tempExpression = firstNumber + secondNumber;
//			stackPush(stack, tempExpression);
//			return;
//		}
//
//		if (operatorOrOperand == minus)
//		{
//			tempExpression = firstNumber - secondNumber;
//			stackPush(stack, tempExpression);
//			return;
//		}
//
//		if (operatorOrOperand == multiplication)
//		{
//			tempExpression = firstNumber * secondNumber;
//			stackPush(stack, tempExpression);
//			return;
//		}
//
//		if (operatorOrOperand == division)
//		{
//			tempExpression = firstNumber / secondNumber;
//			stackPush(stack, tempExpression);
//			return;
//		}
//	}
//	else
//	{ 
//		stackPush(stack, stringToInt(operatorOrOperand));
//	}
//}
//
//void functionThatFindsTheFirstUnprocessedElementToAddToTheStack(TreeElement * treeElement, Stack * stack)
//{
//	if (pointerOnLeftElement(treeElement) != nullptr)
//	{
//		functionThatFindsTheFirstUnprocessedElementToAddToTheStack(pointerOnLeftElement(treeElement), stack);
//	}
//
//	if (pointerOnRightElement(treeElement) != nullptr)
//	{
//		functionThatFindsTheFirstUnprocessedElementToAddToTheStack(pointerOnRightElement(treeElement), stack);
//	}
//
//	doSomethingWithElement(valueElement(treeElement), stack);
//}

int countThis(TreeElement * treeElement)
{
	if (valueElement(treeElement) == "+")
	{
		return countThis(pointerOnLeftElement(treeElement)) + countThis(pointerOnRightElement(treeElement));
	}

	if (valueElement(treeElement) == "-")
	{
		return countThis(pointerOnLeftElement(treeElement)) - countThis(pointerOnRightElement(treeElement));
	}

	if (valueElement(treeElement) == "*")
	{
		return countThis(pointerOnLeftElement(treeElement)) * countThis(pointerOnRightElement(treeElement));
	}

	if (valueElement(treeElement) == "/")
	{
		return countThis(pointerOnLeftElement(treeElement)) / countThis(pointerOnRightElement(treeElement));
	}

	return stringToInt(valueElement(treeElement));
}

int countExpression(Tree * tree)
{
	//Stack * stack = createStack();
	//functionThatFindsTheFirstUnprocessedElementToAddToTheStack(pointerOnHead(tree), stack);
	//int result = stackPop(stack);

	//deleteStack(stack);
	return countThis(pointerOnHead(tree));
}