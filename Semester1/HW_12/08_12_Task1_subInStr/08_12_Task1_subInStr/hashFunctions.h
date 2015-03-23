#pragma once

#include <string>

// Хэш-функция для строки.
int hashFunctionForString(std::string someString, const int simpleNumb);

// Хэш-функция для элемента строки.
int hashFunctionForChar(char someChar, int needPower, const int simpleNumb);