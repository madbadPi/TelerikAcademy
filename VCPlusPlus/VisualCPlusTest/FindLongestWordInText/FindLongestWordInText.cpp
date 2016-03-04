#include <iostream>
#include <stdio.h>
#include <vector>
//using namespace std;

int main()
{
	char ch;	
	int counter = 0;
	int max = 0;
	std::vector<char> inputtext;
	std::cout << "Enter text including '.' at the end of the text" << std::endl;
	int i = 0;
	do
	{
		ch = getchar();
		inputtext.push_back(ch);
		do
		{
			ch = getchar();
			inputtext.push_back(ch);
			counter++;
		} while (ch != '.' && ch != ' ' && ch != '\n');
		if (counter > max)
		{
			max = counter;			
		}
		counter = 0;
	} while (ch != '.');
	std::cout << max << std::endl;
	return 0;
}