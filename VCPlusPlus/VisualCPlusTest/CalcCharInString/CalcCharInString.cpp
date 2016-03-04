#include <iostream>
#include <string>
#include <map>
//using namespace std;

std::string readinput()
{
	std::string currentstring;
	std::cout << "Input your string:" << std::endl;
	std::getline(std::cin, currentstring);
	return currentstring;
}

int main()
{
	std::string mystring = readinput();
	std::map<char, int> mymap;

	int len = mystring.length();

	char currentChar= mystring[0];
	int counter = 0;
	mymap[currentChar] = counter;
	//cout << mystring[mystring.length()-1];
	for (int i = 0; mystring[i+1] != '\0'; i++)
	{			
		for (int j = i; mystring[j] != '\0'; j++)
		{
			if (currentChar == mystring[j])
			{
				counter++;				
			}
		}	
		if (counter > mymap[currentChar])
		{
			mymap[currentChar] = counter;
		}
			
		currentChar = mystring[i + 1];
		counter = 0;
		mymap.insert(std::pair<char, int>(currentChar, counter));
	}
	char prevchar = mystring[len - 2];
	if (currentChar != prevchar)
	{
		if (mymap[currentChar] == 0)
		{
			counter = 1;
			mymap[currentChar] = 1;
		}
		
	}
	std::cout << std::endl;
	return 0;
}