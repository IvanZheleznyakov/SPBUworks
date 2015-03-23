#pragma once

struct StackElement;

struct Stack;

Stack* createStack();

void stackPush(Stack *stack, char bracket); // ���������� �������� � ����.

char stackPop(Stack *stack, bool & stackIsEmpty); // ���������� � ����������� �������� �� �����.

void deleteStack(Stack *stack); // �������� ��������� �� �����.