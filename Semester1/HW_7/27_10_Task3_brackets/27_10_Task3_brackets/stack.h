#pragma once

struct StackElement;

struct Stack;

Stack* createStack();

void stackPush(Stack *stack, char bracket); // Добавление элемента в стек.

char stackPop(Stack *stack, bool & stackIsEmpty); // Извлечение и возвращение элемента из стека.

void deleteStack(Stack *stack); // Удаление элементов из стека.