#include <iostream>
#include <string>

int main()
{
	std::string numberstr;
	std::cout << "Input a number ";
	getline(std::cin, numberstr);
	int num = stoi(numberstr);

	for (int i = 0; i < num; i++)
	{
		for (int j = i + 1; j < num + i + 1; j++)
		{
			std::cout << j;
		}
		std::cout << std::endl;
	}
	std::cout << std::endl;
	return 0;
}