#include <iostream>
#include <string>
//using namespace std;

int main()
{
	std::string myString;
	float myFloat;
	std::cout << "Input your string";
	std::cout << std::endl;
	//it doesn't work
	//cin >> myString;

	std::getline(std::cin, myString);
	for (int i = 0; i < myString.length(); i++)
	{
		std::cout << myString[i];
	}
	std::cout << std::endl;

	std::string firstStr = "I am the ";
	std::string secondStr = "best mom";
	std::cout << firstStr + secondStr;
	return 0;
}