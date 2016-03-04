#include <iostream>
#include <vector>

std::vector<int> findmaxseqinarr(int myarray[], int size)
{
	std::vector<int> newarr;
	int counter = 0;
	int max = 0;
	for (int i = 0; i < size-1; i++)
	{		
		while (myarray[i] == myarray[i+1]-1)
		{
			counter++;
			i++;
		}
		if (counter > max)
		{
			newarr.clear();
			for (int j = 0; j < counter; j++)
			{
				newarr.push_back(myarray[i-counter+1] + j);
			}
			max = counter;
		}
		counter = 1;
	}
	std::cout << std::endl;
	return newarr;
}

void printarr(std::vector<int> result)
{
	std::cout << "{";
	for (int i = 0; i < result.size(); i++)
	{
		std::cout << result[i] << ", ";
	}
	std::cout << "}" << std::endl;
}

int main()
{
	int myarray[] = { 3, 2, 3, 4, 2, 2, 4 };
	int arrsize = sizeof(myarray) / sizeof(myarray[0]);
	std::vector<int> resultarr = findmaxseqinarr(myarray, arrsize);
	printarr(resultarr);
	return 0;
}