#include <iostream>
//using namespace std;

void sumarr(int *arr,int size)
{	
	for (int i = 0; i < 5; i++)
	{
		*arr = *arr + 1;
		++arr;
	}	
	//return arr;
}

int main()
{
	int myarray[] = { 1, 2, 3, 4 };
	//int numbers[7];
	//int * ptr;
	//ptr = numbers;
	//*ptr = 0;
	//ptr++;
	//*ptr = 1;
	//ptr++;
	//*ptr = 2;
	//ptr = numbers + 3;
	//*ptr = 3;
	//ptr = numbers;
	//*(ptr + 4) = 4;
	//*(ptr + 5) = 5;
	//ptr = &numbers[6];
	//*ptr = 6;
	//for (int n = 0; n<7; n++)
	//cout << numbers[n] << " ";
	int size = sizeof(myarray) / sizeof(myarray[0]);
	sumarr(myarray, size);
	//int * newarray = sumarr(myarray, size);		
	std::cout << "some";
	return 0;
}