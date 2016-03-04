#include <iostream>
#include <string>
#include <vector>

std::vector<int> findmaxsumelements(std::vector<int> arr, int k)
{
	std::vector<int> newarr;
	int n = arr.size();
	//first sort the array
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < i; j++)
		{
			if (arr[i] < arr[j])
			{
				std::swap(arr[i], arr[j]);
			}
		}
	}
	//calc sum from the last k-elements in the array
	int maxsum = 0;
	for (int i = n - k - 1; i < n; i++)
	{
		newarr.push_back(arr[i]);
		maxsum += arr[i];
	}
	std::cout << "The max sum is: " << maxsum;
	return newarr;
}

int main()
{
	std::string firstnum;
	std::string secondnum;
	
	std::cout << "Input an integer number N: ";
	std::getline(std::cin, firstnum);
	int n = stoi(firstnum);

	std::cout << "Input an integer number K: ";
	std::getline(std::cin, secondnum);
	int k = stoi(secondnum);

	std::vector<int> arr;
	std::cout << "Input an array with " << n << "elements";
	for (int i = 0; i < n; i++)
	{
		std::string inputstr;
		std::getline(std::cin, inputstr);
		arr.push_back(stoi(inputstr));
	}
	std::vector<int> resultarr = findmaxsumelements(arr, k);
	return 0;
}