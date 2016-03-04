#include <iostream>
#include <vector>
#include <string>

void readinput(std::vector<int>& myarray)
{
	std::string inputline;
	std::cout << "Input array";
	std::getline(std::cin, inputline);
	int len = inputline.length();
	for (int i = 0; i < len; i++)
	{
		//int currntelement = (int)inputline[i];
		myarray.push_back(inputline[i]-'0');
	}
}

bool comparetwoarrays(std::vector<int>firstarray, std::vector<int> secondarray)
{
	int firstlen = firstarray.size();
	int secondlen = secondarray.size();
	bool arraysarethesame = false;
	if (firstlen == secondlen)
	{
		arraysarethesame = true;
		for (int i = 0; i < firstlen; i++)
		{
			if (firstarray[i] != secondarray[i])
			{
				arraysarethesame = false;
				break;
			}
		}
	}
	return arraysarethesame;
}

int main()
{
	std::vector<int> firstarray;
	std::vector<int> secondarray;
	readinput(firstarray);
	readinput(secondarray);
	bool arethesame = comparetwoarrays(firstarray, secondarray);
	std::cout << "The arrays are the same: " << (arethesame ? "true" : "false") << std::endl;
	return 0;
}