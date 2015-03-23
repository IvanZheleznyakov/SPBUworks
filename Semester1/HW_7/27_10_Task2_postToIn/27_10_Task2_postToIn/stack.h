#pragma once

struct StackElement;

struct Stack;

Stack* createStack();

void stackPush(Stack *stack, int number); // Добавление элемента в стек.

int stackPop(Stack *stack, bool & isNotCorrect); // Извлечение и возвращение элемента из стека.

void deleteStack(Stack *stack); // Удаление элементов из стека.