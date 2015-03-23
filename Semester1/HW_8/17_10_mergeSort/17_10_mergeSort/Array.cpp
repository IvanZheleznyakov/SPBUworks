#include <algorithm>

#include "Array.h"

using namespace std;

struct Array
{
	size_t sizeOfArray = 1000;
	size_t numberOfElements = 0;
	int * array = new int[sizeOfArray] {};
};

Array * createLinked()
{
	Array * resultArray = new Array;
	return resultArray;
}

size_t numberOfElements(Array * array)
{
	return array->numberOfElements;
}

void addElement(Array * array, int value)
{
	++array->numberOfElements;
	array->array[array->numberOfElements - 1] = value;
}

int deleteElement(Array * array)
{
	int temp = array->array[array->numberOfElements - 1];
	array->array[array->numberOfElements - 1] = 0;
	--array->numberOfElements;
	return temp;
}

int headValue(Array * array)
{
	return array->array[array->numberOfElements - 1];
}

Array * reverseLinked(Array * array)
{
	for (size_t i = 0; i != array->numberOfElements / 2; ++i)
	{
		swap(array->array[i], array->array[array->numberOfElements - i - 1]);
	}
	return array;
}

void deleteLinked(Array * array)
{
	delete[] array;
}