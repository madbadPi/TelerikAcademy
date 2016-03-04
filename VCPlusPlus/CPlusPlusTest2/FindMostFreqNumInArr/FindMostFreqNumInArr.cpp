#include <iostream>
//#include <map>

int main()
{
	int arr[] = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
	int len = sizeof(arr) / sizeof(arr[0]);

		
	int maxnumcounter = 0;
	int counter = 0;	
	int result = 0;
	//find the most frequent elementin the sorted array
	for (int i = 0; i < len - 1; i++)
	{
		for (int j = i+1; j < len; j++)
		{
			if (arr[j] == arr[i])
			{
				counter++;
				if (counter > maxnumcounter)
				{
					maxnumcounter = counter;
					result = arr[i];
					counter = 0;
				}
			}
		}
	}
	std::cout << result;

	//find the occurance of every element
	//std::map<int, int> mymap;		
	//int currentel = 0;
	//int counter = 1;
	//for (int i = 0; i < len - 1; i++)
	//{
	//	currentel = arr[i];
	//	mymap.insert(std::pair<int, int>(currentel, counter));
	//	for (int j = i + 1; j < len; j++)
	//	{
	//		if (currentel == arr[j])
	//		{
	//			counter++;
	//		}
	//	}
	//	if (counter > mymap[currentel])
	//	{
	//		mymap[currentel] = counter;
	//		
	//	}		
	//	counter = 1;		
	//}
	
	return 0;
}