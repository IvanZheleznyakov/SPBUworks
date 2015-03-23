#pragma once

struct Stack;

Stack * createStack();

// ���������� �������� � ����.
void stackPush(Stack * stack, int value); 

// ���������� � ����������� �������� �� �����.
int stackPop(Stack * stack); 

// �������� ��������� �� �����.
void deleteStack(Stack * stack); 