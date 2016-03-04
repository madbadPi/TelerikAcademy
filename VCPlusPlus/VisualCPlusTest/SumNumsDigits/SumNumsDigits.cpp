#include <iostream>
#include <string>
//using namespace std;

int main()
{
	std::string inputString;
	std::cout << "Input your number:" << std::endl;
	std::getline(std::cin, inputString);
	//int sum = 0;	
	//
	//int size = inputString.length();
	//int inputNum = 0;
	//for (int i = 0; inputString[i] != '\0'; i++)
	//{
	//	char symbol = inputString[i];
	//	//check if it is digit 
	//	sum += symbol - 48;
	//}
	
	int number = std::stoi(inputString);
	int sum = 0;
	while (number > 0)
	{
		sum += number % 10;
		number /= 10;
	};
	std::cout << sum;
	std::cout << std::endl;

	return 0;
}