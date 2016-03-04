/*"Friend bits" are sequences of bits with the same value.
All other bits are "alone bits".For example in 
the sequence 11101010011011010000111010110001 the friend bits
(marked in grey, from left to right) are: 111, 00, 11, 11, 0000, 111, 11
and 000. In the same sequence alone bits are : 0101, 0, 01, 010 and 1.
We are given a 32 - bit integer n.Write a program that extracts 
all friend bits and all alone bits from n.Append all friend bits
in the same order in which they appear in n and print their
decimal representation f.Respectively, append all alone bits
in the order in which they appear in n and print their decimal
representation a.
Input
The input data should be read from the console.It holds
the number n at the first line.
The input data will always be valid and in the format described.
There is no need to check it explicitly.
Output
The output should be printed on the console.It should consist of
exactly 2 lines: the numbers f and a.
Constraints
•	All input and output numbers should be unsigned 32 - bit 
integers in the range[0 to 4 294 967 295].
•	Time limit : 0.1 seconds.
•	Memory limit : 16 MB.
*/
#include <iostream>
#include <string>

std::string convertdecimaltobin(std::string decimalinput)
{
	long long int number = stoll(decimalinput);
	std::string binresult;
	while (number >= 1)
	{
		char currentdigit = (number % 2)+'0';
		binresult = currentdigit + binresult;
		number /= 2;
	}
	//std::cout << std::endl;
	return binresult;
}

int convertbintodecimal(std::string binnumber)
{
	int decimalnumresult = 0;
	int powbase = 1;
	for (int i = binnumber.length() - 1; i >= 0; i--)
	{		
		decimalnumresult += (binnumber[i]-'0') * powbase;
		powbase = powbase * 2;
	}
	return decimalnumresult;
}

void split(std::string inputnum, std::string* friendbits, std::string* alonebits)
{
	//std::string result;

	for (int i = 0; i < inputnum.length() - 1; i++)
	{
		char currentchar = inputnum[i];

		if (currentchar == inputnum[i + 1])
		{
			*friendbits = *friendbits + currentchar;
			while ((i < inputnum.length() - 1)
				&& currentchar == inputnum[i + 1])
			{
				*friendbits = *friendbits + currentchar;
				i++;
			}			
		}
		else
		{
			*alonebits = *alonebits + currentchar;
		}
	}
	if (inputnum[inputnum.length() - 2] != inputnum[inputnum.length() - 1])
	{
		*alonebits = *alonebits + inputnum[inputnum.length() - 1];
	}
	//std::cout <<std::endl;
}

int main()
{
	std::string inputstr;
	getline(std::cin, inputstr);
	std::string binoriginalnum = convertdecimaltobin(inputstr);
	
	std::string friendbits;
	std::string alonebits;

	split(binoriginalnum, &friendbits, &alonebits);

	std::cout << convertbintodecimal(friendbits);
	std::cout << std::endl;

	std::cout << convertbintodecimal(alonebits);
	std::cout << std::endl;
	return 0;
}