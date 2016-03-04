#include <iostream>
#include <array>
//using namespace std;

int main()
{
	//array<int, 10> myArray;
	//
	//int negativeCounter = 0;
	//for (int i = 0; i < myArray.size(); i++)
	//{
	//	cout << "Type the first number";
	//	cin >> myArray[i];
	//	if (myArray[i] < 0)
	//	{
	//		negativeCounter++;
	//	}
	//}
	int myArray[5];
	int negCounter = 0;
	int size = sizeof(myArray) / sizeof(myArray[0]);
	for (int i = 0; i < size; i++)
	{
		std::cout << "Type the first number";
		std::cin >> myArray[i];
		if (myArray[i] < 0)
		{
			negCounter++;
		}
	}
	std::cout << "The number of negative numbers in the collection is:" << negCounter << std::endl;
	return 0;
}