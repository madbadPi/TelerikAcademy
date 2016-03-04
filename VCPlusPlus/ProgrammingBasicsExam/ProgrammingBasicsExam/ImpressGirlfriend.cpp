/*Problem 1 – Impress the girlfriend
Spiro is a big CS GO fan. He's been saving money for months to buy the new 
Counter Strike game. However, he has five options to buy the game from. 
The first one is a shady Russian site selling games in rubles (Russian currency). 
Another option is an American site selling games in dollars (American currency). 
Spiro's third option is the official site of the game - selling games in euros 
(European Union currency). The final 2 options are Bulgarian sites B and M. 
Both of them sell in leva (Bulgarian currency). B offers 
a very special deal - 2 copies of the game for the price of one. 
M sells games for normal prices. Spiro is very bad with math and can't 
calculate the game prices in leva. But he wants to impress his girlfriend 
by showing her he bought the most expensive game.
Assume that Spiro has a girlfriend, all games are identical, 
100 rubles are 3.5 leva, 1 dollar is 1.5 leva, 1 euro is 
1.95 leva and if Spiro buys 2 special games from B and he always 
sell one of them for exactly half of the money he paid for both. 
Your task is to write a program that calculates the most expensive game.
Input
The input data should be read from the console. It consists of five 
input values, each at a separate line:
•	The number r – amount of rubles Spiro has to pay for the game at the Russian site.
•	The number d – amount of dollars Spiro has to pay for the game at the American site.
•	The number e – amount of euro Spiro has to pay for the game at the official site.
•	The number b – amount of leva Spiro has to pay for the special offer at B.
•	The number m – amount of leva Spiro has to pay for the game at M's site.
The input data will always be valid and in the format described. 
There is no need to check it explicitly.
Output
•	The output data must be printed on the console. 
On the only output line you must print the most expensive game price rounded up to
the next integer number.
Constraints
•	The numbers r, d, e, b, m are integer numbers in range [0... 4,294,967,295].
•	Allowed working time for your program: 0.1 seconds.
•	Allowed memory: 16 MB.
*/
#include <iostream>
#include <string>

long long readinput()
{
	std::string inputstring;
	getline(std::cin, inputstring);
	return stoll(inputstring);
}

double max(double a, double b)
{	
	if (b > a)
	{
		return b;
	}
	return a;
}

double converttoleva(long long input, int index)
{
	double result = 0;
	switch (index)
	{
	case 0:
		//100 rubles are 3.5 leva
		result = (input*3.5) / 100;
		break;
	case 1:
		//1 dollar is 1.5 leva
		result = input*1.5;
		break;
	case 2:
		//1 euro is 1.95 leva 
		result = input*1.95;
		break;
	case 3:
		//2 special games from B and he always sell one of them 
		//for exactly half of the money he paid for both
		result = input / 2;
		break;
	case 4:
		result = input;
		break;
	default:
		break;
	}

	return result;
}

int main()
{
	//read input
	const int inputnumbers = 5;
	double currentmaxvalue = 0.00;
	for (int i = 0; i < inputnumbers; i++)
	{
		long long inputvalue = readinput();
		double convinputvalue = converttoleva(inputvalue,i);
		currentmaxvalue = max(convinputvalue, currentmaxvalue);
	}
	double result = ceil(currentmaxvalue);
	std::cout << "The most expensive game costs:" << std::endl << result << std::endl;
	return 0;
}