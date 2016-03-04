#include <iostream>
using namespace std;

int main()
{
	int number = rand() % 100;
	int guess;	
	int counter = 0;
	do
	{
		cout << "Enter a number in the range [0,100]: ";
		cin >> guess;
		if (guess < number)
		{
			cout << "The number is larger than your guess\n";
		}
		else if (guess > number)
		{
			cout << "The number is smaler than your guess\n";
		}
		counter++;
	} while (guess != number);
	cout << "You win\n";	
	cout << "Number of attempts: " << counter << "\n";
	return 0;
}
