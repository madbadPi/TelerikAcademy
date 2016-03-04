#include <iostream>
#include <string>
#include <vector>

long double factorial(int n)
{
	long double result = 1;
	while (n>0)
	{
		result *= n;
		n /= 10;
	}
	return result;
}

int main()
{
	std::string nnumstr;
	std::string xnumstr;
	std::cout << "Enter integer number N: ";
	getline(std::cin, nnumstr);
	std::cout << "Enter integer number X: ";
	getline(std::cin, xnumstr);
	int n = stoi(nnumstr);
	int x = stoi(xnumstr);

	long double sum = 1;
	for (int i = 1; i <= n; i++)
	{		
		sum += factorial(i) / x;
		x = x*x;
	}
	std::cout << "Result of the sum" << std::endl << "S = 1 + 1!/X + 2!/X2 +  + N!/XN";
	std::cout << " is " << sum;
	std::cout << std::endl;
	return 0;
}