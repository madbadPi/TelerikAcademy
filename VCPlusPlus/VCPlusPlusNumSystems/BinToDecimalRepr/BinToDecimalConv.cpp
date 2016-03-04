#include <iostream>
#include <string>

std::string input()
{
	std::string inputline;
	std::cout << "Input binary number: ";	
	getline(std::cin, inputline);
	return inputline;
}

int bintodecimalconv(std::string num)
{
	int result = 0;
	int len = num.size();
	int base = 1;
	for (int i = len - 1; i >= 0; i--)
	{
		result = result + (num[i] - '0') * base;
		base = base * 2;
	}
	return result;
}

int main()
{
	std::string number = input();
	std::cout << bintodecimalconv(number) << std::endl;
	return 0;
}