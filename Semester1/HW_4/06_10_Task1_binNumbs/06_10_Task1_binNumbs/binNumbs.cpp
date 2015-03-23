#include <iostream>
#include <algorithm>

using namespace std;

const size_t sizeOfArray = 100000; // максимальный размер массива дл€ хранени€ двоичного представлени€ числа

struct BinNumbs // класс двоичных чисел
{
	BinNumbs() 
	{
		numberOfSignificantDigits = 0;
		for (size_t i = 0; i != sizeOfArray; ++i)
		{
			binNumb[i] = false;
		}
	}
	int numberOfSignificantDigits; // количество значащих разр€дов
	bool binNumb[sizeOfArray]; // представление двоичного числа в виде массива
};

void decToBin(int decNumber, BinNumbs * binNumber) // перевод дес€тичного числа в двоичное
{
	while (decNumber != 0) // пока число не равно нулю
	{
		binNumber->binNumb[binNumber->numberOfSignificantDigits] = decNumber % 2; // записываем остаток делени€ на два
		++binNumber->numberOfSignificantDigits;                                    // увеличиваем число значащих разр€дов
		decNumber /= 2;
	}
}

void showBinNumb(BinNumbs * binNumber) // вывод двоичного числа на экран
{
	if (!binNumber->numberOfSignificantDigits)
	{
		cout << 0;
		return;
	}
	for (size_t i = binNumber->numberOfSignificantDigits - 1; i != -1; --i)
	{
		cout << binNumber->binNumb[i];
	}
}

void sumOfTwoBinNumbs(BinNumbs * firstNumber, BinNumbs * secondNumber) // функци€ суммы двух двоичных чисел, результат
{																			// записываем в первое число
	bool tempDigit = false; // переменна€, отвечающа€ за битовый перенос
	firstNumber->numberOfSignificantDigits = max(firstNumber->numberOfSignificantDigits, secondNumber->numberOfSignificantDigits); // если требуетс€, увеличиваем количество значащих разр€дов
	for (size_t i = 0; i != firstNumber->numberOfSignificantDigits; ++i)
	{
		int tempResultDigit = firstNumber->binNumb[i] + secondNumber->binNumb[i] + tempDigit; // побитово складываем оба
		firstNumber->binNumb[i] = tempResultDigit % 2;											// числа и учитываем перенос
		tempDigit = tempResultDigit / 2;
	}
	
	if (tempDigit)
	{
		firstNumber->binNumb[firstNumber->numberOfSignificantDigits] = tempDigit;
		++firstNumber->numberOfSignificantDigits;
	}
}

int binToDec(BinNumbs * number) // перевод двоичного числа в дес€тичное
{
	int resultInDec = 0;
	for (size_t i = 0; i != number->numberOfSignificantDigits; ++i)
	{
		resultInDec += number->binNumb[i] * pow(2, i);
	}
	return resultInDec;
}

int main()
{
	setlocale(LC_ALL, "Russian");

	int firstNumberInDec = -1;
	int secondNumberInDec = -1;

	while (firstNumberInDec < 0 || secondNumberInDec < 0)
	{
		cout << "¬ведите два целых неотрицательных числа: ";
		cin >> firstNumberInDec >> secondNumberInDec;
		if (firstNumberInDec < 0 || secondNumberInDec < 0)
		{
			cout << "Ќекорректный ввод. ѕопробуйте еще раз." << endl;
		}
	}
	
	BinNumbs * firstNumberInBin = new BinNumbs;
	BinNumbs * secondNumberInBin = new BinNumbs;

	decToBin(firstNumberInDec, firstNumberInBin);
	decToBin(secondNumberInDec, secondNumberInBin);

	cout << "ѕервое число в двоичном представлении: ";
	showBinNumb(firstNumberInBin);
	cout << endl;

	cout << "¬торое число в двоичном представлении: ";
	showBinNumb(secondNumberInBin);
	cout << endl;

	cout << "—умма чисел в двоичном представлении: ";
	sumOfTwoBinNumbs(firstNumberInBin, secondNumberInBin);
	showBinNumb(firstNumberInBin);
	cout << endl;

	cout << "—умма чисел в дес€тичном представлении: " << binToDec(firstNumberInBin) << endl;

	delete[] firstNumberInBin;
	delete[] secondNumberInBin;

	return 0;
}

// ћои тесты.
// ¬ходные данные: 23 81
// ¬ыходные данные: 
// 10111
// 1010001
// 1101000
// 104

// ¬ходные данные: 15 0
// ¬ыходные данные:
// 1111
// 0
// 1111
// 15