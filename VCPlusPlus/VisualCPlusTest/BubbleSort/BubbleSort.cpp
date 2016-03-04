#include <iostream>
//using namespace std;

void bubblesort(int* ptr,int size)
{
	bool swapped = true;	
		
	for (int i = 0; (i < size) && swapped; i++)
	{
		swapped = false;
		for (int j = i; j < size - 1; j++)
		{
			if (*(ptr + j+1) < *(ptr + j))
			{				
				std::swap(*(ptr + j+1), *(ptr + j));				
				swapped = true;
			}			
		}
	}
	
	std::cout << std::endl;
}

int main()
{
	int myArray[] = { 12, -50, 600, 2, 3 };
	int size = sizeof(myArray) / sizeof(myArray[0]);
	int * prtMyArray = myArray;
	bubblesort(prtMyArray, size);
	return 0;
}