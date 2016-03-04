#include <iostream>

void printarray(int* parray,int size)
{	
	for (int i = 0; i < size; i++)
	{
		std::cout << "array[" << i << "]" << "=" << *(parray + i) << std::endl;
	}
}

int main()
{
	int myarray[20];
	int len = 20;
	for (int i = 0; i < len; i++)
	{
		myarray[i] = i * 5;
	}
	printarray(myarray, len);
	return 0;
}