/*Twisted Fate loves to play with cards! His favourite one is Ace of Diamonds. 
Your task is to draw Ace of Diamonds on the conole by given width/height. 
See examples below to understand the task better.
Input
The input data should be read from the console. It consists of one input value:
•	On the only input line you will recieve width/height of the card.
The input data will always be valid and in the format described. 
There is no need to check it explicitly.
Output
The Ace of Diamonds must be printed on the console. 
Constraints
•	The number will be odd integer number in range [3... 4,294,967,295].
•	Allowed working time for your program: 0.1 seconds.
•	Allowed memory: 16 MB.


3
***
*@*
***

5
*****
*-@-*
*@@@*
*-@-*
*****

7
*******
*--@--*
*-@@@-*
*@@@@@*
*-@@@-*
*--@--*
*******

*/
#include <iostream>
#include <string>

void printsymbols(int lenght, char symbol)
{
	for (int i = 0; i < lenght; i++)
	{
		std::cout << symbol;
	}
	
}

int main()
{
	std::string line;
	getline(std::cin, line);
	int cardwidth = stoi(line);
	//first line
	printsymbols(cardwidth, '*');
	std::cout << std::endl;

	int halfwidth = cardwidth / 2;
	int undescorenum = halfwidth - 1;

	for (int row = 0; row < halfwidth-1; row++)
	{				
		std::cout << "*";
		printsymbols(undescorenum, '_');
		printsymbols(2*row + 1, '@');		
		printsymbols(undescorenum, '_');		
		std::cout << "*";
		std::cout << std::endl;	
		undescorenum--;
	}

		std::cout << "*";
		printsymbols(cardwidth - 2, '@');
		std::cout << "*";
		std::cout << std::endl;	

	undescorenum = 1;
	for (int row = halfwidth -2; row >= 0; row--)
	{		
		std::cout << "*";
		printsymbols(undescorenum, '_');
		printsymbols(2 * row + 1, '@');
		printsymbols(undescorenum, '_');
		std::cout << "*";
		std::cout << std::endl;		
		undescorenum++;
	}

	//last line
	printsymbols(cardwidth, '*');
	std::cout << std::endl;
	return 0;
}