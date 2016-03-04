#include <iostream>

int main()
{
	int arr[] = { 5, 2, -1, 0, 12, 5, 120 };
	int n = sizeof(arr) / sizeof(arr[0]);
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < i; j++)
		{
			if (arr[i] < arr[j])
			{
				std::swap(arr[j], arr[i]);
			}
		}
	}
	std::cout << std::endl;
	return 0;
}