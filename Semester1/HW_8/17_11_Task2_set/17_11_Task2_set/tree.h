#pragma once

struct Tree;

// Создание дерева.
Tree * createTree();

// Добавление элемента в дерево.
void addElement(Tree *tree, int addedValue);

// Удаление элемента из дерева.
void deleteElement(Tree * tree, int deletedValue);

// Проверка, находится ли элемент во множестве.
bool checkElement(Tree * tree, int checkedValue);

// Вывод дерева на экран.
void printTree(Tree *tree, bool sortByDescending);

// Удаление дерева.
void deleteTree(Tree * tree);