#include <iostream>
#include <fstream>

using namespace std;

const int maxNumbOfNodes = 20;

// Алгоритм Прима.
void algorithmOfPrim(int numbOfNodes, int graf[maxNumbOfNodes][maxNumbOfNodes], int spanningTree[maxNumbOfNodes][maxNumbOfNodes])
{
	const int infinity = 100000;
	bool visitedNodes[maxNumbOfNodes] { false };
	visitedNodes[0] = true;
	bool somethingIsChanged = true;
	while (somethingIsChanged)
	{
		somethingIsChanged = false;
		int tempOut = -1;
		int tempIn = -1;
		int tempMin = infinity;
		for (int i = 0; i != numbOfNodes; ++i)
		{
			if (visitedNodes[i])
			{
				for (int j = 0; j != numbOfNodes; ++j)
				{
					if (!visitedNodes[j] && tempMin > graf[i][j] && graf[i][j] != 0)
					{
						tempOut = i;
						tempIn = j;
						tempMin = graf[i][j];
						somethingIsChanged = true;
					}
				}
			}
		}
		if (somethingIsChanged)
		{
			spanningTree[tempIn][tempOut] = tempMin;
			spanningTree[tempOut][tempIn] = tempMin;
			visitedNodes[tempIn] = true;
			visitedNodes[tempOut] = true;
		}
	}
}

// Вывод на консоль остовного дерева.
void showSpanningTree(int numbOfNodes, int spanningTree[maxNumbOfNodes][maxNumbOfNodes])
{
	for (int i = 0; i != numbOfNodes; ++i)
	{
		for (int j = 0; j != numbOfNodes; ++j)
		{
			cout << spanningTree[i][j] << " ";
		}
		cout << endl;
	}
}

void main()
{
	setlocale(LC_ALL, "Russian");

	int graf[maxNumbOfNodes][maxNumbOfNodes];
	int spanningTree[maxNumbOfNodes][maxNumbOfNodes];

	fstream input("graf.txt");
	if (input.eof())
	{
		cout << "Файл пуст." << endl;
		input.close();
		return;
	}

	int numbOfNodes = 0;
	input >> numbOfNodes;
	for (int i = 0; i != numbOfNodes; ++i)
	{
		for (int j = 0; j != numbOfNodes; ++j)
		{
			graf[i][j] = 0;
			spanningTree[i][j] = 0;
		}
	}
	for (int i = 0; i != numbOfNodes; ++i)
	{
		for (int j = 0; j != numbOfNodes; ++j)
		{
			input >> graf[i][j];
		}
	}

	input.close();

	algorithmOfPrim(numbOfNodes, graf, spanningTree);

	cout << "Остовное дерево выглядит следующим образом: " << endl;

	showSpanningTree(numbOfNodes, spanningTree);

}
 /*
 Мои тесты.
 Вход: 
 5
 0 3 4 0 1
 3 0 5 0 0
 4 5 0 2 6
 0 0 2 0 7
 1 0 6 7 0

 Выход:
 0 3 4 0 1
 3 0 0 0 0
 4 0 0 2 0
 0 0 2 0 0
 1 0 0 0 0

 ___________
 Вход:
 7
 0 9 0 5 15 6 0
 9 0 8 7 7 0 0
 0 8 0 0 5 0 0
 5 7 0 0 0 0 0
 15 7 5 0 0 8 9
 6 0 0 0 8 0 11
 0 0 0 0 9 11 0

 Выход:
 0 0 0 5 0 6 0
 0 0 0 7 7 0 0
 0 0 0 0 5 0 0
 5 7 0 0 0 0 0
 0 7 5 0 0 0 9
 6 0 0 0 0 0 0
 0 0 0 0 9 0 0

 */
