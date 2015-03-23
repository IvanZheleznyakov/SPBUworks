#include "tree.h"
#include <string>
#include <iostream>

using namespace std;

struct TreeElement
{
	string value;
	TreeElement *left = nullptr;
	TreeElement *right = nullptr;
};

struct Tree
{
	TreeElement *head = nullptr;
};

Tree * createTree()
{
	return new Tree;
}

TreeElement * pointerOnLeftElement(TreeElement * treeElement)
{
	return treeElement->left;
}

TreeElement * pointerOnRightElement(TreeElement * treeElement)
{
	return treeElement->right;
}

TreeElement * pointerOnHead(Tree * tree)
{
	return tree->head;
}

string valueElement(TreeElement * treeElement)
{
	return treeElement->value;
}

void addElementInHead(Tree * tree, TreeElement * newElement)
{
	tree->head = newElement;
}

void addElementInNotHead(Tree * tree, TreeElement * cursor, TreeElement * newElement, bool & addedElement)
{
	if (!addedElement)
	{
		if (cursor->left == nullptr)
		{
			cursor->left = newElement;
			addedElement = true;
			return;
		}
		if (cursor->left->value == "+" || cursor->left->value == "-" || cursor->left->value == "*" || cursor->left->value == "/")
		{
			addElementInNotHead(tree, cursor->left, newElement, addedElement);
		}
	}
	if (!addedElement)
	{
		if (cursor->right == nullptr)
		{
			cursor->right = newElement;
			addedElement = true;
			return;
		}
		if (cursor->right->value == "+" || cursor->right->value == "-" || cursor->right->value == "*" || cursor->right->value == "/")
		{
			addElementInNotHead(tree, cursor->right, newElement, addedElement);
		}
	}
}

void addElement(Tree * tree, string addedValue)
{
	TreeElement * newElement = new TreeElement;
	newElement->value = addedValue;
	if (tree->head == nullptr)
	{
		addElementInHead(tree, newElement);
		return;
	}
	
	TreeElement * cursor = tree->head;
	bool addedElement = false;
	addElementInNotHead(tree, cursor, newElement, addedElement);
}

void printTreeElement(TreeElement * treeElement)
{
	if (treeElement->left != nullptr)
	{
		printTreeElement(treeElement->left);
	}

	cout << treeElement->value << " ";

	if (treeElement->right != nullptr)
	{
		printTreeElement(treeElement->right);
	}
}

void printTree(Tree *tree)
{
	setlocale(LC_ALL, "Russian");

	if (tree->head == nullptr)
	{
		cout << "Множество пусто." << endl;
		return;
	}

	printTreeElement(tree->head);
}

void deleteTreeElement(TreeElement * treeElement)
{
	if (treeElement->left != nullptr)
	{
		deleteTreeElement(treeElement->left);
	}

	if (treeElement->right != nullptr)
	{
		deleteTreeElement(treeElement->right);
	}

	delete treeElement;
}

void deleteTree(Tree * tree)
{
	if (tree->head != nullptr)
	{
		deleteTreeElement(tree->head);
	}

	delete tree;
}