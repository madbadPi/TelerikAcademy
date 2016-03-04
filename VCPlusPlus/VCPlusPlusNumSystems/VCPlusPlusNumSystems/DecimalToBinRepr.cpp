#include <iostream>
#include <string>
//#include <vector>

int input()
{
	std::string inputline;
	std::cout << "Input a number:";
	std::getline(std::cin, inputline);	
	return std::stoi(inputline);
}

std::string decimaltobinconv(int num)
{
	std::string result;
	int base = 2;
	
	while (num > 0)
	{				
		char currentnum = (num & 1) + '0';
		result = currentnum + result;
		num = num >> 1;
	}
	return result;
}

int main()
{
	int number = input();
	std::cout << decimaltobinconv(number) << std::endl;
	return 0;
}