#include <iostream>
#include <string>
//using namespace std;

int main()
{
	std::string firstLine;
	std::cout << "Input x = ";
	std::getline(std::cin, firstLine);
	int x = stoi(firstLine);
	std::string secondLine;
	std::cout << "Input n = ";
	std::getline(std::cin, secondLine);
	int n = stoi(secondLine);
	//int middleresult = pow(x, n + 1);
	int middleresult = 1;
	for (int i = 0; i < n + 1; i++)
	{
		middleresult *= x;
	}
	double sum = (1 - middleresult) / (1 - x);
	std::cout << sum << std::endl;
	return 0;
}