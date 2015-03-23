#pragma once
#include <string>

struct TreeElement;

struct Tree;

// �������� ������.
Tree * createTree();

// ������� ��������� �� ����� �������.
TreeElement * pointerOnLeftElement(TreeElement * treeElement);

// ������� ��������� �� ������ �������.
TreeElement * pointerOnRightElement(TreeElement * treeElement);

// ������� ��������� �� ������.
TreeElement * pointerOnHead(Tree * tree);

// ������� �������� ��������.
std::string valueElement(TreeElement * treeElement);

// ���������� �������� � ������.
void addElement(Tree * tree, std::string addedValue);

// ����� ������ �� �����.
void printTree(Tree * tree);

// �������� ������.
void deleteTree(Tree * tree);