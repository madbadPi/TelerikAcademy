#include <iostream>
#include <string>
//using namespace std;

void drawpyramid(int height)
{
	char mychar;
	std::cout << "Input symbol: ";
	std::cin >> mychar;
	
	int symbolsbefore = height - 1;
	int symbolsafter = height - 1;
	for (int i = 0; i < height; i++)
	{
		for (int j = symbolsbefore - i; j > 0; j--)
		{
			std::cout << ' ';
		}

		for (int j = 1; j <= (i*2)+1; j++)
		{
			std::cout << mychar;
		}

		for (int j = symbolsafter - i; j > 0; j--)
		{
			std::cout << ' ';
		}
		std::cout << std::endl;
	}
}

int main()
{
	std::cout << "Input pyramid height: ";
	std::string inputheightstr;
	std::getline(std::cin, inputheightstr);
	int height = std::stoi(inputheightstr);
	drawpyramid(height);	
	return 0;
}