#include <iostream>
#include <string>

using namespace std;

int main()
{
	setlocale(LC_ALL, "Russian");

	int helpArray[10] {0};
	string number;

	cout << "������� �����:" << endl;
	cin >> number;
	if (number[0] == '0')
	{
		cout << "������������ ����!" << endl;
		return 0;
	}

	for (size_t i = 0; i != number.size(); ++i)
	{
		if (number[i] < '0' || number[i] > '9')
		{
			cout << "������������ ����!" << endl;
			return 0;
		}
		++helpArray[number[i] - '0'];
	}

	cout << "���������� ����� �� ���� ������� �����: " << endl;
	for (size_t i = 1; i != 10; ++i)
	{
		if (helpArray[i])
		{
			cout << i;
			--helpArray[i];
			break;
		}
	}

	for (size_t i = 0; i != 10; ++i)
	{
		while (helpArray[i])
		{
			cout << i;
			--helpArray[i];
		}
	}
	cout << endl;

	return 0;
}

//��� �����.
//������� ������ :
//30201
//
//�������� ������ :
//10023
//___________________
//������� ������ :
//-23
//
//�������� ������ :
//������
//___________________
//������� ������ :
//023
//
//�������� ������ :
//������
//___________________
//������� ������ :
//Twenty three
//
//�������� ������ :
//������