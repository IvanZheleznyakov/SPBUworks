#pragma once
#include <string>

struct TreeElement;

struct Tree;

// Создание дерева.
Tree * createTree();

// Вернуть указатель на левый элемент.
TreeElement * pointerOnLeftElement(TreeElement * treeElement);

// Вернуть указатель на правый элемент.
TreeElement * pointerOnRightElement(TreeElement * treeElement);

// Вернуть указатель на голову.
TreeElement * pointerOnHead(Tree * tree);

// Вернуть значение элемента.
std::string valueElement(TreeElement * treeElement);

// Добавление элемента в дерево.
void addElement(Tree * tree, std::string addedValue);

// Вывод дерева на экран.
void printTree(Tree * tree);

// Удаление дерева.
void deleteTree(Tree * tree);