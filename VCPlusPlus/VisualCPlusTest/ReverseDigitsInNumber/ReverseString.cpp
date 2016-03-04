#include <iostream>
#include <string>
//using namespace std;

int main()
{
	std::string inputstr;
	std::cout << "Input string: ";
	std::getline(std::cin, inputstr);
	int length = inputstr.length();
	std::string resultstr;
	for (int i = 0; i < length; i++)
	{
		resultstr += inputstr[length - 1 - i];
	}
	std::cout << resultstr << std::endl;
	return 0;
}