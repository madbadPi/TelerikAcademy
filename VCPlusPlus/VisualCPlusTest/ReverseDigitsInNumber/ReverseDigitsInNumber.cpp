#include <iostream>
#include <string>
//using namespace std;

int main()
{
	std::string inputnum;
	std::cout << "Input a number" << std::endl;
	std::getline(std::cin, inputnum);
	//int len = inputnum.length();
	int number = stoi(inputnum);
	int resultnum = 0;
	while (number > 0)
	{
		resultnum = resultnum * 10 + number % 10;
		number /= 10;
	}
	std::cout << resultnum << std::endl;
	return 0;
}