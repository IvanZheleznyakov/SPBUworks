#pragma once

#include <string>

// ���-������� ��� ������.
int hashFunctionForString(std::string someString, const int simpleNumb);

// ���-������� ��� �������� ������.
int hashFunctionForChar(char someChar, int needPower, const int simpleNumb);