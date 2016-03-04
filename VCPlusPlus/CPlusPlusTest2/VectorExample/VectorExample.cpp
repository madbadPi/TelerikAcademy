#include <iostream>
#include <vector>
//pass vector to function by reference
void sortvector(std::vector<int>& myvector)
{
	int length = myvector.size();
	//bubble sort
	for (int i = 0; i < length; i++)
	{
		for (int j = 0; j < i; j++)
		{
			if (myvector[j]>myvector[j + 1])
			{
				std::swap(myvector[j], myvector[j + 1]);
			}
		}
	}	
}
//pass vector to function by pointer
void printvector(const std::vector<int>* pvector, int size)
{
	for (int i = 0; i < size; i++)
	{
		std::cout << (*pvector)[i]<<", ";		
	}
}

int main()
{
	std::vector<int> testvector = { 1, -2, 0, 15, 18 };
	int size = testvector.size();
	sortvector(testvector);
	printvector(&testvector, size);	
	return 0;
}