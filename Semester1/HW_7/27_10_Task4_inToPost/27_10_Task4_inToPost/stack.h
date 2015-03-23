#pragma once

struct StackElement;

struct Stack;

Stack* createStack();

// Добавление элемента в стек.
void stackPush(Stack *stack, char symbol); 

// Возвращение символа из стека.
char stackHeadSymbol(Stack *stack);

// Проверка на пустоту стека.
bool stackIsEmpty(Stack *stack);

// Извлечение и возвращение элемента из стека.
char stackPop(Stack *stack, bool & isNotCorrect); 

// Удаление элементов из стека.
void deleteStack(Stack *stack); 

// Инвертирование стека.
Stack * reverseStack(Stack *stack);

// Сообщение о некорректном выводе.
void incorrectInput(Stack * stackOutput, Stack * stackOperations);