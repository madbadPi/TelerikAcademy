#include <iostream>
#include <string>
//using namespace std;

int main()
{
	std::string inputtext = "Some Simple text smile :), me Se S";
	//cout << "Input some text:" << endl;
	//getline(cin, inputtext);

	char mychar = 'S';
	//cout << "Input the first char of the word that we are counting: ";
	//cin >> mychar;
	int counter = 0;
	int wordscounter = 0;
	for (int i = 0; i < inputtext.length(); i++)
	{
		char currenchar = inputtext[i];			
		while (currenchar != ' '
			&& ((currenchar >= 'A' && currenchar <= 'Z')
			|| (currenchar >= 'a' && currenchar <= 'z')))
		{
			counter++;	
			i++;
			currenchar = inputtext[i];
		}		
		if (inputtext[i - counter] == mychar)
		{
			wordscounter++;
		}
		counter = 0;
	}
	std::cout << wordscounter << std::endl;
	return 0;
}