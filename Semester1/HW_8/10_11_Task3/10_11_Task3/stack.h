#pragma once

struct Stack;

Stack * createStack();

// Добавление элемента в стек.
void stackPush(Stack * stack, int value); 

// Извлечение и возвращение элемента из стека.
int stackPop(Stack * stack); 

// Удаление элементов из стека.
void deleteStack(Stack * stack); 