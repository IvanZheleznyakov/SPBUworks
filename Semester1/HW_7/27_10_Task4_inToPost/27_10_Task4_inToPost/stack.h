#pragma once

struct StackElement;

struct Stack;

Stack* createStack();

// ���������� �������� � ����.
void stackPush(Stack *stack, char symbol); 

// ����������� ������� �� �����.
char stackHeadSymbol(Stack *stack);

// �������� �� ������� �����.
bool stackIsEmpty(Stack *stack);

// ���������� � ����������� �������� �� �����.
char stackPop(Stack *stack, bool & isNotCorrect); 

// �������� ��������� �� �����.
void deleteStack(Stack *stack); 

// �������������� �����.
Stack * reverseStack(Stack *stack);

// ��������� � ������������ ������.
void incorrectInput(Stack * stackOutput, Stack * stackOperations);