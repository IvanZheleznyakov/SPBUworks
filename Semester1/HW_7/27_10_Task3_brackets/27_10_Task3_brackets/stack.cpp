#include "stack.h"

struct StackElement
{
	char bracket;
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

void stackPush(Stack *stack, char bracket)
{
	StackElement *newElement = new StackElement;
	newElement->bracket = bracket;
	newElement->next = stack->head;
	stack->head = newElement;
}

char stackPop(Stack *stack, bool & stackisEmpty)
{
	if (stack->head == nullptr)
	{
		stackisEmpty = true;
		return -1;
	}

	char bracket = stack->head->bracket;
	StackElement *temp = stack->head->next;
	delete stack->head;
	stack->head = temp;
	return bracket;
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