#include <iostream>

int main()
{
	int arr[] = { 5, 2, -1, 0, 12, 5, 120 };
	int n = sizeof(arr) / sizeof(arr[0]);
	int min = 0;
	for (int i = 0; i < n; i++)
	{
		min = i;
		for (int j = i + 1; j < n; j++)
		{
			if (arr[j] < arr[min])
			{
				min = j;
			}
		}
		if (i != min)
		{
			std::swap(arr[i], arr[min]);
		}

	}
	std::cout << std::endl;
	return 0;
}
