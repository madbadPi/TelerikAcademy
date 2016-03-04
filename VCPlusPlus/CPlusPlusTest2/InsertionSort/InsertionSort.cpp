#include <iostream>

int main()
{
	int arr[] = { 1, 2, -10, -10, 5, -10, 120, 50, 0 };
	int n = sizeof(arr) / sizeof(arr[0]);
	int counter = 0;
	for (int i = 0; i < n-1; i++)
	{
		int j = i + 1;

		while (j > 0 && arr[j] < arr[i])
		{
			std::swap(arr[i], arr[j]);
			j--;
			i--;
			counter++;
		}
		i += counter;
		counter = 0;
	}
	std::cout << std::endl;
	return 0;
}
