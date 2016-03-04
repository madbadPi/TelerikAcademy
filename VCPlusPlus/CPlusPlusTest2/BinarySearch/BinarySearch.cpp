#include <iostream>
#include <string>
int main()
{
	int myarr[] = { 10, 12, 1, 0, -12, 120, 240 };
	int len = sizeof(myarr) / sizeof(myarr[0]);

	//the first step is sorting the array
	//bubble sort
	for (int i = 0; i < len; i++)
	{
		for (int j = 0; j < i; j++)
		{
			if (myarr[i] < myarr[j])
			{
				std::swap(myarr[i], myarr[j]);
			}
		}
	}

	//binary search
	int number = 0;
	std::string inputstring;
	std::cout << "Type the number that you are searching for: ";
	std::getline(std::cin, inputstring);
	number = stoi(inputstring);

	int min = 0;
	int max = len - 1;
	int mid = min + ((max - min) / 2);
	int resultindex = -1;

	while (min <= max)
	{
		mid = min + ((max - min) / 2);
		if (myarr[mid] == number)
		{
			resultindex = mid;
			break;
		}
		else if (myarr[mid]> number)
		{
			max = mid - 1;
			//mid = min + ((max - min) / 2);
		}
		else
		{
			min = mid + 1;
			//mid = min + ((max - min) / 2);
		}
	}
	if (resultindex < 0)
	{
		std::cout << "Number not found" << std::endl;
	}
	else
	{
		std::cout << "The index of number " << number << " is " 
			<< resultindex << std::endl;
	}	
	return 0;
}