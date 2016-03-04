#include <iostream>
#include <vector>

int main()
{
	int array[] = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
	std::vector<int> newarray;
	int size = sizeof(array) / sizeof(array[0]);
	int counter = 1;
	int max = 0;
	for (int i = 0; i < size - 1; i++)
	{		
		while (array[i] == array[i+1])
		{					
			counter++;
			i++;
		}
		if (counter > max)
		{		
			newarray.clear();
			for (int j = 0; j < counter; j++)
			{
				newarray.push_back(array[i]);
			}			
			max = counter;
		}
		counter = 1;		
	}
	std::cout << max << std::endl;
	return 0;
}