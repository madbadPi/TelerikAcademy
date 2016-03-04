#include <iostream>
#include <string>

int main()
{
	std::string inputnum;
	std::cout << "Input number N: ";
	getline(std::cin, inputnum);
	int num = stoi(inputnum);

	
	int firstfibonacci = 0;
	int secondfibonacci = 1;
	int sum = 1;	
	int currentfibonacci;
	for (int i = 2; i <= num; i++)
	{
		currentfibonacci = firstfibonacci + secondfibonacci;
		sum += currentfibonacci;
		firstfibonacci = secondfibonacci;
		secondfibonacci = currentfibonacci;		
	}
	std::cout << sum;
	return 0;
}