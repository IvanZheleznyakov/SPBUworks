#include <iostream>

using namespace std;

int powerSlow(int powerBase, int power)
{
	int savePowerBase = powerBase;

	for (int i = 1; i < power; i++)
	{
		powerBase *= savePowerBase;
	}

	return powerBase;
}

int powerFast(int powerBase, int power)
{
	if (power == 0)
	{
		return 1;
	}
	else if (power == 1)
	{
		return powerBase;
	}
	else
	{
		if (power % 2 == 0)
		{
			int res = powerFast(powerBase, power / 2);
			return res*res;
		}
		else
		{
			return powerFast(powerBase, power - 1) * powerBase;
		}
	}
}

int main()
{
	int choiceOfImplementation = 0;

	while (choiceOfImplementation != -1)
	{
		cout << "Iterative implementation (slow): 1" << endl;
		cout << "Recursive implementation (fast): 2" << endl;
		cout << "Quit: -1" << endl;
		cout << "Choose, please: ";
		cin >> choiceOfImplementation;

		if (choiceOfImplementation != -1)
		{
			int powerBase = 0;
			int power = 0;

			cout << "Enter power base: ";
			cin >> powerBase;
			cout << "Enter power: ";
			cin >> power;

			if (choiceOfImplementation == 1)
			{
				cout << "Result " << powerSlow(powerBase, power) << endl;
			}
			else
			{
				cout << "Result: " << powerFast(powerBase, power) << endl;
			}

			cout << "You can try again." << endl;
		}
	}
	
	return 0;

}