/*Write a program to remove all sequences of k equal elements 
from a sequence of integers. For example, if we have 
the sequence 3 3 3 8 8 2 5 1 7 7 7 4 4 4 4 3 4 4 and we 
remove all sequences of k = 2 elements, we will 
obtain 3 2 5 1 7 3. For k = 3, we will obtain the following 
result: 8 8 2 5 1 4 3 4 4. For k = 1, the result will be empty.
Input
The input data comes from the console. It should consist of a 
two lines:
•	The first line holds the input numbers, separated one 
from another by a space.
•	The second line holds the number k.
The input data will always be valid and in the format described. 
There is no need to check it explicitly.
Output
The output should be printed on the console. It should consist
of a single line holding the obtained sequence of numbers. 
Separate each number from the next number by a space.
Constraints
•	The input sequence numbers are integers in the range [-1000 … 1000].
•	The count of the input numbers is in the range [1 … 1000].
•	The number k is integer in the range [1 … 1000].
•	Time limit: 0.1 seconds.
•	Memory limit: 16 MB.
*/
#include <iostream>
#include <string>
#include <vector>

void readinput(std::vector<int>* myarray, int* k)
{
	std::string firstline;
	getline(std::cin, firstline);
	int len = firstline.length();

	//input numbers in myarray
	for (int i = 0; i < len ; i++)
	{
		char currchar = firstline[i];
		int currnum = 0;
		//input positive values
		if (currchar != '-')
		{
			while (currchar != ' '&& i < len)
			{
				currnum = currnum * 10 + (currchar - '0');
				i++;
				currchar = firstline[i];
			}
			myarray->push_back(currnum);
		}
		//input negative values
		else
		{
			//need to move i because the currchar is '-'
			i++;
			currchar = firstline[i];
			while (currchar != ' '&& i < len)
			{				
				currnum = currnum * 10 - (currchar - '0');
				i++;
				currchar = firstline[i];
			}
			myarray->push_back(currnum);
		}
		
	}	

	std::string secondline;
	getline(std::cin, secondline);
	*k = stoi(secondline);
}

std::vector<int> removesequences(std::vector<int> inputarray,int k)
{
	std::vector<int> result;
	if (k > 1)
	{
		for (int i = 0; i < inputarray.size(); i++)
		{
			int currelement = inputarray[i];
			int counter = 1;

			while ((i < inputarray.size() - 1) && currelement == inputarray[i + 1])
			{
				counter++;
				i++;				
			}
			if (counter < k)
			{
				for (int j = 0; j < counter; j++)
				{
					result.push_back(currelement);
				}
			}
			else if (counter > k)
			{
				i = i - counter + k;
			}
		}
	}
	return result;
}

void print(std::vector<int> array)
{
	for (int i = 0; i < array.size(); i++)
	{
		std::cout << array[i];
		if (i != array.size() - 1)
		{
			std::cout << " ";
		}
	}
	std::cout << std::endl;
}

int main()
{
	std::vector<int> inputarray;
	int k = 0;
	//passing inputarray and k to function by pointer
	readinput(&inputarray, &k);
	std::vector<int> result = removesequences(inputarray, k);
	print(result);
	return 0;
}