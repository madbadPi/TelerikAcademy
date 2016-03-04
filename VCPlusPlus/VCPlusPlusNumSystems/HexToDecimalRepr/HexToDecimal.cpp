#include <iostream>
#include <string>

int hextodecimalconv(std::string hexnum)
{
	int result = 0;
	int len = hexnum.size();
	char currentchar;
	int base = 16; 
	int pow = 1;
	while (len > 0)
	{
		currentchar = hexnum[len - 1];
		if (currentchar >='0' && currentchar<='9')
		{			
			result += (currentchar - '0')*pow;
		}
		else
		{
			result += (currentchar - 55)*pow;
		}		
		pow *= base;		
		len--;		
	}
	return result;
}

int main()
{
	std::string hexnum;
	std::cout << "Input hexadecimal number: ";
	getline(std::cin, hexnum);
	int decimalnum = hextodecimalconv(hexnum);
	std::cout << decimalnum << std::endl;
	return 0;
}