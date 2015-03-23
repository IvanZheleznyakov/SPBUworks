#include "stack.h"

struct StackElement
{
	int value;
	StackElement *next;
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

void stackPush(Stack *stack, int number)
{
	StackElement *newElement = new StackElement;
	newElement->value = number;
	newElement->next = stack->head;
	stack->head = newElement;
}

int stackPop(Stack *stack, bool & isNotCorrect)
{
	if (stack->head == nullptr)
	{
		isNotCorrect = true;
		return -1;
	}

	int value = stack->head->value;
	StackElement *temp = stack->head->next;
	delete stack->head;
	stack->head = temp;
	return value;
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