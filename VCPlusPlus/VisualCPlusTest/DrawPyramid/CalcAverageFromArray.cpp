#include <iostream>
#include <string>	
//using namespace std;

int main()
{
	std::cout << "Input number of numbers: ";
	std::string inputnum;
	std::cin >> inputnum;
	int len = stoi(inputnum);	
	int sum = 0;
	for (int i = 0; i < len; i++)
	{
		std::string currentNum;
		std::cout << "Input number";
		std::cin >> currentNum;
		int number = stoi(currentNum);
		if (number > 0 && number%2==0)
		{
			sum += number;
		}

	}
	std::cout << "The sum of all positive even numbers in the input array is: " << sum << std::endl;
	return 0;
}