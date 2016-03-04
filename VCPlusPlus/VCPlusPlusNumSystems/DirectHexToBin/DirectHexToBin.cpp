#include <iostream>
#include <string>

std::string hextobinconv(std::string input)
{
	std::string result;
	std::string array[] = {
		"0000", "0001", "0010", "0011", "0100", "0101",
		"0110", "0111", "1000", "1001", "1010", "1011",
		"1100", "1101", "1110", "1111" };
	int len = input.size();
	for (int i = 0; i < len; i++)
	{	
		char currentchar = input[i]; 
		int index = 0;
		if (currentchar >= '0' && currentchar <= '9')
		{
			index = currentchar - '0';			
		}
		else
		{
			index = currentchar - 'A' + 10;
		}
		result = result + array[index];
	}
	return result;
}

int main()
{
	std::string inputline;
	std::cout << "Input hexadecimal number: ";
	getline(std::cin, inputline);
	std::cout << hextobinconv(inputline);
	return 0;
}