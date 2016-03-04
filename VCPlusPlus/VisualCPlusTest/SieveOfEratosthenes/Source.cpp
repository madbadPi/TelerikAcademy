#include <iostream>
#include <vector>
//using namespace std;

int main()
{
	//initialize
	//int n;
	//std::cout << "Input number:" << std::endl;
	//std::cin >> n;		
	//std::vector<bool> myVector(n);
	//for (int i = 2; i < n ; i++)
	//{
	//	myVector[i] = true;
	//}
	//
	//int size = myVector.size();
	//for (int i = 2; i < sqrt(size); i++)
	//{
	//	if (myVector[i])
	//	{
	//		for (int j = i*i; j < myVector.size(); j+=i)
	//		{
	//			myVector[j] = false;
	//		}
	//	}
	//}
	//
	////print
	//for (int i = 0; i < myVector.size(); i++)
	//{
	//	if (myVector[i])
	//	{
	//		std::cout << i << ", ";
	//	}
	//}	



	int * firstptr;
	int first ;
	
	firstptr = &first;
	std::cout << *firstptr++ << std::endl;
	std::cout << &first << std::endl;
	std::cout << firstptr << std::endl;
	std::cout << *++firstptr << std::endl;
	std::cout << ++*firstptr << std::endl;
	std::cout << (*firstptr)++;

	std::cout << std::endl;
	return 0;
}