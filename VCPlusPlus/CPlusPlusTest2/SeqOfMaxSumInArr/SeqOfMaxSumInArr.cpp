#include <iostream>
#include <vector>

int findmaxseqsum(int arr[], int size)
{
	//vector<int> newarr;
	int tempsum = 0;
	int maxsum = INT_MIN;	
	for (int i = 0; i < size; i++)
	{
		tempsum += arr[i];		
		if (tempsum > maxsum)
		{

			maxsum = tempsum;
		}
		if (tempsum < 0)
		{
			tempsum = 0;			
		}
	}
	return maxsum;
}

int main()
{
	int arr[] = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };	
	int size = sizeof(arr) / sizeof(arr[0]);
	std::cout << findmaxseqsum(arr, size);
	return 0;
}