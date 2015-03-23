#include <string>

#include "hashFunctions.h"

using namespace std;

int hashFunctionForString(string someString, const int simpleNumb)
{
	int power = 1;
	int result = 0;
	for (int i = someString.length() - 1; i != -1; --i)
	{
		result += static_cast<int>(someString[i]) * power;
		power *= simpleNumb;
	}

	return result;
}

int hashFunctionForChar(char someChar, int needPower, const int simpleNumb)
{
	int power = 1;
	for (int i = 1; i != needPower; ++i)
	{
		power *= simpleNumb;
	}
	return static_cast<int>(someChar)* power;
}