/*Nakov likes boxes. Ha has many boxes at home. To save space he often puts his 
boxes one inside another. A box can fit inside another box if the size of the 
smaller box is smaller than the size of the bigger box in all dimensions at the 
same time. Of course, boxes can be rotated to fit one inside another. 
Here are few examples:
•	(5, 1, 6) fits naturally in (6, 2, 9), because 5 < 6 and 1 < 2 and 6 < 9
•	(5, 1, 6) fits in (2, 7, 6) after rotating the second box to (6, 2, 7)
•	(7, 8, 1) cannot fit in (12, 7, 3) even after rotating
•	(6, 2, 9) cannot fit in (5, 1, 6) even after rotating
You are given the sizes of two boxes (width, height and depth). 
Write a program to check whether the boxes can fit one inside another and how exactly. 
Print the smaller box first, exactly as it is given in the input (without rotating), 
followed by "<" and the larger box (eventually rotated) to fit each of the dimensions. 
Print all possible ways to put the smaller box into the larger box. In case there is no 
smaller box, print nothing. See the examples below to catch the idea.
Input
The input data comes from the console. It holds exactly 6 different numbers, each at 
a separate line:
•	The first 3 lines hold the dimensions of the first box (width, height and depth).
•	The second 3 lines hold the dimensions of the second box (width, height and depth).
The input data will always be valid and in the format described. There is no need to 
check it explicitly.
Output
The output should be printed on the console. It should consist of zero or more lines:
•	If a smaller box exists, print all possible ways to fit the smaller box (without 
rotation) in the larger box (eventually rotated) in format: (w1, h1, d1) < (w2, h2, d2).
Note that the first box is smaller if w1 < w2 and h2 < h2 and d1 < d2. 
Beware of whitespaces in the output format!
•	Print each possible fit into a separate line. The lines order is not important.
•	In case of no smaller box exists, print nothing.
Constraints
•	All input numbers are unique integers in [1 … 1000].
•	Time limit: 0.1 seconds.
•	Memory limit: 16 MB
*/
#include <iostream>
#include <string>

struct box{
	int width;
	int height;
	int depth;
};

box readinput()
{
	box currentbox;
	std::string strwidth;
	getline(std::cin, strwidth);
	currentbox.width = stoi(strwidth);

	std::string strheight;
	getline(std::cin, strheight);
	currentbox.height = stoi(strheight);

	std::string strdepth;
	getline(std::cin, strdepth);
	currentbox.depth = stoi(strdepth);

	return currentbox;
}

void printresult(box firstbox, int secondwidth, int secondheight, int seconddepth)
{
	std::cout << '(' << firstbox.width << ", "
		<< firstbox.height << ", " << firstbox.depth << ") < ("
		<< secondwidth << ", " << secondheight
		<< ", " << seconddepth << ')';
	std::cout << std::endl;
}

int findsolution(box firstbox, box secondbox,bool flip)
{
	//int result = 0;	

	if ((firstbox.width < secondbox.width) &&
		(firstbox.height < secondbox.height) &&
		(firstbox.depth < secondbox.depth))
	{		
		//first < second
		printresult(firstbox, secondbox.width, secondbox.height, secondbox.depth);
	}
	if ((firstbox.width < secondbox.height) &&
		(firstbox.height < secondbox.width) &&
		(firstbox.depth < secondbox.depth))
	{
		//first < second
		
		printresult(firstbox, secondbox.height, secondbox.width, secondbox.depth);
		
	}
	if ((firstbox.width < secondbox.height) &&
		(firstbox.height < secondbox.depth) &&
		(firstbox.depth < secondbox.width))
	{
		//first < second
		printresult(firstbox, secondbox.height, secondbox.depth, secondbox.width);
	}
	if ((firstbox.width < secondbox.width) &&
		(firstbox.height < secondbox.depth) &&
		(firstbox.depth < secondbox.height))
	{
		//first < second
		printresult(firstbox, secondbox.width, secondbox.depth, secondbox.height);
	}
	if ((firstbox.width < secondbox.depth) &&
		(firstbox.height < secondbox.height) &&
		(firstbox.depth < secondbox.width))
	{
		//first < second
		printresult(firstbox, secondbox.depth, secondbox.height, secondbox.width);
	}
	if ((firstbox.width < secondbox.depth) &&
		(firstbox.height < secondbox.width) &&
		(firstbox.depth < secondbox.height))
	{
		//first < second
		printresult(firstbox, secondbox.depth, secondbox.width, secondbox.height);
	}
	else
	{
		//check if the second box is smaller
		if (!flip)
		{
			findsolution(secondbox, firstbox, true);
		}
		//if there is no smaller box
		else
		{
			return 0;
		}
	}
	return 0;
}

int main()
{
	//read input
	box firstbox = readinput();
	box secondbox = readinput();

	findsolution(firstbox, secondbox, false);
	return 0;
}