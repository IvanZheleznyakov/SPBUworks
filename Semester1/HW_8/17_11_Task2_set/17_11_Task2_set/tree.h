#pragma once

struct Tree;

// �������� ������.
Tree * createTree();

// ���������� �������� � ������.
void addElement(Tree *tree, int addedValue);

// �������� �������� �� ������.
void deleteElement(Tree * tree, int deletedValue);

// ��������, ��������� �� ������� �� ���������.
bool checkElement(Tree * tree, int checkedValue);

// ����� ������ �� �����.
void printTree(Tree *tree, bool sortByDescending);

// �������� ������.
void deleteTree(Tree * tree);