#include <iostream>
#include <algorithm>

using namespace std;

const size_t sizeOfArray = 100000; // ������������ ������ ������� ��� �������� ��������� ������������� �����

struct BinNumbs // ����� �������� �����
{
	BinNumbs() 
	{
		numberOfSignificantDigits = 0;
		for (size_t i = 0; i != sizeOfArray; ++i)
		{
			binNumb[i] = false;
		}
	}
	int numberOfSignificantDigits; // ���������� �������� ��������
	bool binNumb[sizeOfArray]; // ������������� ��������� ����� � ���� �������
};

void decToBin(int decNumber, BinNumbs * binNumber) // ������� ����������� ����� � ��������
{
	while (decNumber != 0) // ���� ����� �� ����� ����
	{
		binNumber->binNumb[binNumber->numberOfSignificantDigits] = decNumber % 2; // ���������� ������� ������� �� ���
		++binNumber->numberOfSignificantDigits;                                    // ����������� ����� �������� ��������
		decNumber /= 2;
	}
}

void showBinNumb(BinNumbs * binNumber) // ����� ��������� ����� �� �����
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

void sumOfTwoBinNumbs(BinNumbs * firstNumber, BinNumbs * secondNumber) // ������� ����� ���� �������� �����, ���������
{																			// ���������� � ������ �����
	bool tempDigit = false; // ����������, ���������� �� ������� �������
	firstNumber->numberOfSignificantDigits = max(firstNumber->numberOfSignificantDigits, secondNumber->numberOfSignificantDigits); // ���� ���������, ����������� ���������� �������� ��������
	for (size_t i = 0; i != firstNumber->numberOfSignificantDigits; ++i)
	{
		int tempResultDigit = firstNumber->binNumb[i] + secondNumber->binNumb[i] + tempDigit; // �������� ���������� ���
		firstNumber->binNumb[i] = tempResultDigit % 2;											// ����� � ��������� �������
		tempDigit = tempResultDigit / 2;
	}
	
	if (tempDigit)
	{
		firstNumber->binNumb[firstNumber->numberOfSignificantDigits] = tempDigit;
		++firstNumber->numberOfSignificantDigits;
	}
}

int binToDec(BinNumbs * number) // ������� ��������� ����� � ����������
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
		cout << "������� ��� ����� ��������������� �����: ";
		cin >> firstNumberInDec >> secondNumberInDec;
		if (firstNumberInDec < 0 || secondNumberInDec < 0)
		{
			cout << "������������ ����. ���������� ��� ���." << endl;
		}
	}
	
	BinNumbs * firstNumberInBin = new BinNumbs;
	BinNumbs * secondNumberInBin = new BinNumbs;

	decToBin(firstNumberInDec, firstNumberInBin);
	decToBin(secondNumberInDec, secondNumberInBin);

	cout << "������ ����� � �������� �������������: ";
	showBinNumb(firstNumberInBin);
	cout << endl;

	cout << "������ ����� � �������� �������������: ";
	showBinNumb(secondNumberInBin);
	cout << endl;

	cout << "����� ����� � �������� �������������: ";
	sumOfTwoBinNumbs(firstNumberInBin, secondNumberInBin);
	showBinNumb(firstNumberInBin);
	cout << endl;

	cout << "����� ����� � ���������� �������������: " << binToDec(firstNumberInBin) << endl;

	delete[] firstNumberInBin;
	delete[] secondNumberInBin;

	return 0;
}

// ��� �����.
// ������� ������: 23 81
// �������� ������: 
// 10111
// 1010001
// 1101000
// 104

// ������� ������: 15 0
// �������� ������:
// 1111
// 0
// 1111
// 15