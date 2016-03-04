#include <iostream>
#include <string>
#include <vector>

void factorial(int n)
{
	std::vector<int> a;	
	a.push_back(1);  //initialize array with only 1 digit, the digit 1.
	
	int m = 1;    // initialize digit counter
	int x = 0;
	int carry = 0; //initialize carry variable to 0.
	for (int i = 1; i <= n; i++)
	{
		for (int j = 0; j<m; j++)
		{
			x = a[j] * i + carry; //x contains the product
			a[j] = x % 10; //Contains a digit from the product to store in position j
			carry = x / 10; //Contains the carry value that will be stored on upper indexes
		}
		while (carry > 0) //while loop that will store the carry value on array.
		{
			a.push_back(carry % 10);
			carry = carry / 10;
			m++; // increments digit counter
		}
	}

	//print result
	for (int i = a.size()-1; i >=0; i--)
	{
		std::cout << a[i];
	}
	std::cout << std::endl;
}

int main()
{
	std::string inputline;
	std::cout << "Type a number: ";
	getline(std::cin, inputline);
	int num = stoi(inputline);	
	factorial(num);
	return 0;
}