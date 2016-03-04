#include <iostream>
#include <string>

int main()
{
	std::string firstnum;
	std::string secondnum;
	std::cout << "Enter integer number a: ";
	getline(std::cin, firstnum);
	std::cout << "Enter integer number b: ";
	getline(std::cin, secondnum);
	int a = stoi(firstnum);
	int b = stoi(secondnum);
	int gcd = 0;
	if (a < b)
	{
		std::swap(a, b);
	}
	while (b != 0)
	{
		gcd = a%b;
		a = b;
		if (gcd == 0)
		{
			gcd = abs(b);
			b = 0;
		}
		else
		{
			b = gcd;
		}
	}
	std::cout << gcd << std::endl;
	return 0;
}