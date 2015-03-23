#include "stack.h"
#include <iostream>

using namespace std;

struct StackElement
{
	char symbol = ' ';
	StackElement *next = nullptr;
};

struct Stack
{
	StackElement *head = nullptr;
};

Stack* createStack()
{
	Stack * stack = new Stack;
	return stack;
}

void stackPush(Stack *stack, char symbol)
{
	StackElement *newElement = new StackElement;
	newElement->symbol = symbol;
	newElement->next = stack->head;
	stack->head = newElement;
}

char stackHeadSymbol(Stack *stack)
{
	return stack->head->symbol;
}

bool stackIsEmpty(Stack *stack)
{
	return (stack->head == nullptr);
}

char stackPop(Stack *stack, bool & isNotCorrect)
{
	if (stack->head == nullptr)
	{
		isNotCorrect = true;
		return -1;
	}

	char symbol = stack->head->symbol;
	StackElement *temp = stack->head->next;
	delete stack->head;
	stack->head = temp;
	return symbol;
}

void deleteStack(Stack *stack)
{
	while (stack->head != nullptr)
	{
		StackElement *temp = stack->head->next;
		delete stack->head;
		stack->head = temp;
	}

	delete stack;
}

Stack * reverseStack(Stack *stack)
{
	Stack * tempStack = createStack();
	bool test = false;
	while (stack->head != nullptr)
	{
		stackPush(tempStack, stackPop(stack, test));
	}
	deleteStack(stack);
	return tempStack;
}


void incorrectInput(Stack * stackOutput, Stack * stackOperations)
{
	cout << "Некорректный ввод." << endl;
	deleteStack(stackOutput);
	deleteStack(stackOperations);
}