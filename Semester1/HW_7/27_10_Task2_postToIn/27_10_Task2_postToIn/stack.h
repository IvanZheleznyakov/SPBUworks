#pragma once

struct StackElement;

struct Stack;

Stack* createStack();

void stackPush(Stack *stack, int number); // ���������� �������� � ����.

int stackPop(Stack *stack, bool & isNotCorrect); // ���������� � ����������� �������� �� �����.

void deleteStack(Stack *stack); // �������� ��������� �� �����.