#include <iostream>

int comparetwoarrays(char firstarr[], int firstsize, char secondarr[], int secondsize)
{
	int result = 0;
	int min = 0;
	if (firstsize < secondsize)
	{
		min = firstsize;
	}
	else
	{
		min = secondsize;
	}

	for (int i = 0; i < min; i++)
	{
		if (firstarr[i] == secondarr[i] && firstsize == secondsize)
		{			
			result = 0;
		}
		else if (firstarr[i] == secondarr[i] && firstsize < secondsize)
		{
			result = -1;
		}
		else if (firstarr[i] == secondarr[i] && firstsize > secondsize)
		{
			result = 1;
		}
		if (firstarr[i] < secondarr[i])
		{
			result = -1;
			break;
		}
		if (firstarr[i] > secondarr[i])
		{
			result = 1;
			break;
		}
	}
	return result;
}

int main()
{
	char firstarray[] = {'a','b'};
	int firstsize = sizeof(firstarray) / sizeof(firstarray[0]);
	char secondarray[] = { 'a'};
	int secondsize = sizeof(secondarray) / sizeof(secondarray[0]);
	std::cout << comparetwoarrays(firstarray, firstsize, secondarray, secondsize) << std::endl;
	return 0;
}