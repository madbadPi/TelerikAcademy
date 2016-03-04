#include <iostream>
#include <string>

int main()
{
	std::string inputnumstr;
	std::cout << "Input a number ";
	getline(std::cin, inputnumstr);
	
	int n = stoi(inputnumstr);
	int TrailingZero = 0;
	for (int i = 5; n / i >= 1; i *= 5)
	{
		TrailingZero += n / i;
	}
	std::cout << "There are " << TrailingZero << " zeroes in the factorial of " << n;
	return 0;
}