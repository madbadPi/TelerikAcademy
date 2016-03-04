#include <iostream>
#include <string>

int input()
{
	std::string inputline;
	std::cout << "Input number: ";
	std::getline(std::cin, inputline);
	int result = stoi(inputline);
	return result;
}

std::string convertdectohex(int number)
{
	std::string result;
	int base = 16;
	char hexsymbols[] = { 'A', 'B', 'C', 'D', 'E', 'F' };
	while (number > 0)
	{
		char currentnum = number % 16 + '0';
		if (currentnum >= '0' && currentnum <= '9')
		{
			result = currentnum + result;
		}
		else
		{
			currentnum = hexsymbols[(number % 16) - 10];
			result = currentnum + result;
		}
		number = number / 16;
	}

	return result;
}

int main()
{
	int decimalnum = input();
	std::string hexnum = convertdectohex(decimalnum);
	std::cout << hexnum << std::endl;
	return 0;
}