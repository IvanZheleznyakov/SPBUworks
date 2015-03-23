#include "List.h"
#include "Array.h"
#include "mergeSort.h"

Linked * merge(Linked * linked, Linked * tempLinked)
{
	Linked * sortLinked = createLinked();
	size_t sizeOfSortLinked = numberOfElements(linked) + numberOfElements(tempLinked);

	linked = reverseLinked(linked);
	tempLinked = reverseLinked(tempLinked);

	for (size_t i = 0; i != sizeOfSortLinked; ++i)
	{
		if (numberOfElements(linked) && numberOfElements(tempLinked))
		{
			if (headValue(linked) > headValue(tempLinked))
			{
				addElement(sortLinked, deleteElement(linked));
			}
			else
			{
				addElement(sortLinked, deleteElement(tempLinked));
			}
		}
		else if (numberOfElements(linked))
		{
			addElement(sortLinked, deleteElement(linked));
		}
		else
		{
			addElement(sortLinked, deleteElement(tempLinked));
		}
	}

	deleteLinked(linked);
	deleteLinked(tempLinked);

	return sortLinked;
}

Linked * mergeSort(Linked * linked)
{
	if (numberOfElements(linked) != 1)
	{
		Linked * tempLinked = createLinked();
		size_t middle = numberOfElements(linked) / 2;
		while (numberOfElements(linked) > middle)
		{
			addElement(tempLinked, deleteElement(linked));
		}

		linked = merge(mergeSort(linked), mergeSort(tempLinked));

	}
	return linked;
}