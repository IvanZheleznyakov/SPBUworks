#include <iostream>

using namespace std;

int FibIterative(int indexOfFibNumb)
{
	if (indexOfFibNumb <= 1)
		return indexOfFibNumb;
	else
	{
		int const sizeOfArray = 3;
		int lastNumbs[sizeOfArray];

		lastNumbs[0] = 0;
		lastNumbs[1] = 1;
		lastNumbs[2] = 1;

		for (int i = 2; i < indexOfFibNumb; i++)
		{
			lastNumbs[0] = lastNumbs[1];
			lastNumbs[1] = lastNumbs[2];
			lastNumbs[2] = lastNumbs[1] + lastNumbs[0];
		}
		return lastNumbs[2];
	}
}

int FibRecursive(int indexOfFibNumb)
{
	if (indexOfFibNumb <= 1)
		return indexOfFibNumb;
	else
	{
		return FibRecursive(indexOfFibNumb - 1) + FibRecursive(indexOfFibNumb - 2);
	}
}

int main()
{
	int choiceOfImplementation = 0;

	while (choiceOfImplementation != -1)
	{
		cout << "Iterative implementation: 1" << endl;
		cout << "Recursive implementation: 2" << endl;
		cout << "Quit: -1" << endl;
		cout << "Choose, please: ";
		cin >> choiceOfImplementation;

		if (choiceOfImplementation != -1)
		{
			int indexOfFibNumb = 0;
			cout << "Enter index of Fibonacci number: ";
			cin >> indexOfFibNumb;

			if (choiceOfImplementation == 1)
			{
				cout << "Fibonacci number: " << FibIterative(indexOfFibNumb) << endl;
			}
			else
			{
				cout << "Fibonacci number: " << FibRecursive(indexOfFibNumb) << endl;
			}

			cout << "You can try again." << endl;
		}
	}

	return 0;

}