#include "tree.h"
#include <iostream>

using namespace std;

struct TreeElement
{
	int value = 0;
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

void addElement(Tree *tree, int addedValue)
{
	TreeElement *newElement = new TreeElement;
	newElement->value = addedValue;

	TreeElement *cursor = tree->head;
	if (cursor != nullptr)
	{
		while (addedValue != cursor->value)
		{
			if (addedValue < cursor->value)
			{
				if (cursor->left == nullptr)
				{
					cursor->left = newElement;
					break;
				}
				cursor = cursor->left;
			}
			else if (addedValue > cursor->value)
			{
				if (cursor->right == nullptr)
				{
					cursor->right = newElement;
				}
				cursor = cursor->right;
			}
			else
			{
				return;
			}
		}
	}
	else
	{
		tree->head = newElement;
	}
}

void deleteElement(Tree * tree, int deletedValue)
{
	if (tree->head == nullptr)
	{
		cout << "Список пуст." << endl;
		return;
	}

	TreeElement * cursor = tree->head;
	TreeElement * tempParent = cursor;

	while (cursor->value != deletedValue)
	{
		if (cursor->value > deletedValue)
		{
			if (cursor->left == nullptr)
			{
				cout << "Такого элемента нет в списке." << endl;
				return;
			}
			if (cursor->left->value == deletedValue)
			{
				tempParent = cursor;
			}
			cursor = cursor->left;
		}

		else if (cursor->value < deletedValue)
		{
			if (cursor->right == nullptr)
			{
				cout << "Такого элемента нет в списке." << endl;
				return;
			}
			if (cursor->right->value == deletedValue)
			{
				TreeElement * tempParent = cursor;
			}
			cursor = cursor->right;
		}
	}

	if (tempParent->value == deletedValue)
	{
		if (cursor->left == nullptr && cursor->right == nullptr)
		{
			tree->head = nullptr;
			delete tempParent;
			return;
		}

		if (cursor->left == nullptr)
		{
			TreeElement * tempElement = cursor->right;
			delete cursor;
			tree->head = tempElement;
			return;
		}

		if (cursor->right == nullptr)
		{
			TreeElement * tempElement = cursor->left;
			delete cursor;
			tree->head = tempElement;
			return;
		}

		TreeElement * secondTempParent = cursor;
		cursor = cursor->right;
		if (cursor->left == nullptr)
		{
			TreeElement * tempElement = cursor->right;
			tempParent->value = cursor->value;
			delete cursor;
			secondTempParent->right = tempElement;
			return;
		}
		while (cursor->left != nullptr)
		{
			secondTempParent = cursor;
			cursor = cursor->left;
		}
		TreeElement * tempElement = cursor->right;
		tempParent->value = cursor->value;
		delete cursor;
		secondTempParent->left = tempElement;
		return;
	}

	if (tempParent->right->value == deletedValue)
	{
		if (cursor->left == nullptr && cursor->right == nullptr)
		{
			delete tempParent->right;
			tempParent->right = nullptr;
			return;
		}

		if (cursor->left == nullptr)
		{
			TreeElement * tempElement = cursor->right;
			delete cursor;
			tempParent->right = tempElement;
			return;
		}

		if (cursor->right == nullptr)
		{
			TreeElement * tempElement = cursor->left;
			delete cursor;
			tempParent->right = tempElement;
			return;
		}

		TreeElement * secondTempParent = cursor;
		cursor = cursor->right;
		if (cursor->left == nullptr)
		{
			TreeElement * tempElement = cursor->right;
			tempParent->right->value = cursor->value;
			delete cursor;
			secondTempParent->right = tempElement;
			return;
		}
		while (cursor->left != nullptr)
		{
			secondTempParent = cursor;
			cursor = cursor->left;
		}
		TreeElement * tempElement = cursor->right;
		tempParent->right->value = cursor->value;
		delete cursor;
		secondTempParent->left = tempElement;
		return;
	}

	if (tempParent->left->value == deletedValue)
	{
		if (cursor->left == nullptr && cursor->right == nullptr)
		{
			delete tempParent->left;
			tempParent->left = nullptr;
			return;
		}

		if (cursor->left == nullptr)
		{
			TreeElement * tempElement = cursor->right;
			delete cursor;
			tempParent->left = tempElement;
			return;
		}

		if (cursor->right == nullptr)
		{
			TreeElement * tempElement = cursor->left;
			delete cursor;
			tempParent->left = tempElement;
			return;
		}

		TreeElement * secondTempParent = cursor;
		cursor = cursor->right;
		if (cursor->left == nullptr)
		{
			TreeElement * tempElement = cursor->right;
			tempParent->left->value = cursor->value;
			delete cursor;
			secondTempParent->right = tempElement;
			return;
		}
		while (cursor->left != nullptr)
		{
			secondTempParent = cursor;
			cursor = cursor->left;
		}
		TreeElement * tempElement = cursor->right;
		tempParent->left->value = cursor->value;
		delete cursor;
		secondTempParent->left = tempElement;
		return;
	}

}

bool checkElement(Tree * tree, int checkedValue)
{
	TreeElement *cursor = tree->head;
	if (cursor != nullptr)
	{
		while (checkedValue != cursor->value)
		{
			if (checkedValue < cursor->value)
			{
				if (cursor->left == nullptr)
				{
					return false;
				}
				cursor = cursor->left;
			}
			else if (checkedValue > cursor->value)
			{
				if (cursor->right == nullptr)
				{
					return false;
				}
				cursor = cursor->right;
			}
		}
		return true;
	}
	return false;
}

void printTreeElement(TreeElement * treeElement, bool sortByDescending)
{
	if (sortByDescending)
	{
		if (treeElement->right != nullptr)
		{
			printTreeElement(treeElement->right, sortByDescending);
		}

		cout << treeElement->value << " ";

		if (treeElement->left != nullptr)
		{
			printTreeElement(treeElement->left, sortByDescending);
		}
	}
	else
	{
		if (treeElement->left != nullptr)
		{
			printTreeElement(treeElement->left, sortByDescending);
		}

		cout << treeElement->value << " ";

		if (treeElement->right != nullptr)
		{
			printTreeElement(treeElement->right, sortByDescending);
		}
	}
}

void printTree(Tree *tree, bool sortByDescending)
{
	setlocale(LC_ALL, "Russian");

	if (tree->head == nullptr)
	{
		cout << "Множество пусто." << endl;
		return;
	}

	printTreeElement(tree->head, sortByDescending);
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

/*TreeElement *cursor = tree->head;
if (cursor != nullptr)
{
if (tree->head->value == deletedValue)
{
delete tree->head;
tree->head = nullptr;
return;
}
while (deletedValue != cursor->value)
{
if (deletedValue < cursor->value)
{
if (cursor->left == nullptr)
{
cout << "Такого элемента нет во множестве." << endl;
return;
}
if (cursor->left->value == deletedValue && cursor->left->left == nullptr && cursor->left->right == nullptr)
{
delete cursor->left;
cursor->left = nullptr;
return;
}
cursor = cursor->left;
}
else if (deletedValue > cursor->value)
{
if (cursor->right == nullptr)
{
cout << "Такого элемента нет во множестве." << endl;
return;
}
if (cursor->right->value == deletedValue && cursor->right->left == nullptr && cursor->right->right == nullptr)
{
delete cursor->right;
cursor->right = nullptr;
return;
}
cursor = cursor->right;
}
}
TreeElement * firstTemp = cursor;
if (cursor->left == nullptr)
{
if (cursor->right->right == nullptr)
{
cursor->value = cursor->right->value;
delete cursor->right;
cursor->right = nullptr;
return;
}
while (cursor->right->right != nullptr)
{
cursor = cursor->right;
}
TreeElement * secondTemp = cursor->right;
firstTemp->value = cursor->right->value;
if (cursor->right->left != nullptr)
{
cursor->right = cursor->right->left;
}
delete secondTemp;
firstTemp->left = firstTemp->right;
firstTemp->right = nullptr;
return;
}
if (cursor->right == nullptr)
{
if (cursor->left->left == nullptr)
{
cursor->value = cursor->left->value;
delete cursor->left;
cursor->left = nullptr;
return;
}
while (cursor->left->left != nullptr)
{
cursor = cursor->left;
}
TreeElement * secondTemp = cursor->left;
firstTemp->value = cursor->left->value;
if (cursor->left->right != nullptr)
{
cursor->left = cursor->left->right;
}
delete secondTemp;
firstTemp->right = firstTemp->left;
firstTemp->left = nullptr;
return;
}

cursor = cursor->right;
if (cursor->left == nullptr)
{
firstTemp->value = cursor->value;
firstTemp->right = firstTemp->right->right;
delete cursor;
return;
}
while (cursor->left->left != nullptr)
{
cursor = cursor->left;
}
TreeElement * secondTemp = cursor->left;
firstTemp->value = cursor->left->value;
if (cursor->left->right != nullptr)
{
cursor->left = cursor->left->right;
}
else
{
cursor->left = nullptr;
}
delete secondTemp;
return;
}
cout << "Множество пусто." << endl;*/