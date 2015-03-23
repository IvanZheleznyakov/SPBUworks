#include <iostream>
#include <algorithm>

#include "List.h"
#include "Array.h"
#include "mergeSort.h"

using namespace std;

void main()
{
	typedef Array Linked;
	//typedef List Linked;
	Linked * linked = createLinked();
	for (int i = 0; i != 7; ++i)
	{
		int value = 0;
		cin >> value;
		addElement(linked, value);
		//addElement(array, value);
	}
	mergeSort(linked);
	deleteLinked(linked);
}