#include <iostream>
//using namespace std;

void sum(int *firstnum, int *secondnum)
{
	*firstnum += *secondnum;
}

int main()
{
	//int * myptr;
	int number1 = 1;
	int number2 = 2;

	//myptr = &number1;
	//*myptr = 5; // ����������� ���������� 5 ��� ������� � �������, �������� �� ��������� myptr (� ������ ������������ number1 �� ������ �� ���� �����)
	//myptr = &number2;
	//*myptr = 3; // ��������� ���� ����� �� ������ ���?
	//number1 += number2;
	//cout << "number1 = " << number1 << endl;
	//cout << "number2 = " << number2 << endl;

	sum(&number1, &number2);
	std::cout << number1;
	return 0;
}