#include <iostream>
//using namespace std;

double sum(double a, double b)
{	
	double result;
	result = a + b;
	return result;
}

int main()
{
	double firstNum = 0;
	double secondNum = 0;

	std::cout << "Input first number:" << std::endl;
	std::cin >> firstNum;
	std::cout << "Input second number:" << std::endl;
	std::cin >> secondNum;
	double result = sum(firstNum, secondNum);
	std::cout << result;
	return 0;
}