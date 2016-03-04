/*Problem 2 – Take the plane down
Apocalypse is coming! Zombies raised up, but they are not ordinarily zombies. 
They can manage fighters.
You are governor of security of Wonderland and you need to protect your country. 
We assume that Wonderland territory is a complete circle and your headquarters are 
located exactly in the middle of the country. The zombies will try to cross your 
air borders and you need to take them down. You can do that only when they are 
over your air space.
You will be given coordinates (x,y) of your headquarters and the distance to the
borders. On the next line you will receive the number of the fighters that are
approaching your country. After that for the next N * 2 lanes you will be given 
all the planes coordinates. You need to calculate the distance to every one of
them and if they are inside your country shoot them. For every plane you destroy
you need to print a message for it on the console: You destroyed a plane at [x,y]. 
Where x and y are the coordinates of the plane.
Input
The input data should be read from the console. It consists of:
•	On the first line you will be given the X of your headquarter.
•	On the second line you will be given the Y of your headquarter.
•	On the third line you will be given the distance from your headquarter to the borders.
•	On the fourth line you will be given the number of the planes that are approaching
On the next 2*N lines you will be given:
•	On the every odd line you will be given the plane X coordinate
•	on the every even line you will be given the plane Y coordinate
The input data will always be valid and in the format described. 
There is no need to check it explicitly.
Output
The output must consist of massage for every plane that is destroyed.
Constraints
•	The coordinates of your headquarter, distance to the borders, number 
of the planes and planes coordinates will be 
integers in range [-2,147,483,648 to 2,147,483,647].
•	Allowed working time for your program: 0.1 seconds.
•	Allowed memory: 16 MB.
*/
#include <iostream>
#include <string>

struct point
{
	int xcoord;
	int ycoord;
};

double calcdistance(point headquarters, point plane)
{
	double xresult = (plane.xcoord - headquarters.xcoord)*(plane.xcoord - headquarters.xcoord);
	double yresult = (plane.ycoord - headquarters.ycoord)*(plane.ycoord - headquarters.ycoord);
	double result = sqrt(xresult + yresult);
	return result;
}

int main()
{
	//read the input
	//first line xcoord of headquarters
	std::string firstline;
	getline(std::cin, firstline);
	//second line ycoord of headquarters
	std::string secondline;
	getline(std::cin, secondline);

	point headquaters;
	headquaters.xcoord = stoi(firstline);
	headquaters.ycoord = stoi(secondline);

	int radius = 0;
	std::string thirdline;
	getline(std::cin, thirdline);
	radius = stoi(thirdline);

	int numplanes = 0;
	std::string fouthline;
	getline(std::cin, fouthline);
	numplanes = stoi(fouthline);

	point * pointer = new point[numplanes];	

	//input planes coordinates
	for (int i = 0; i < numplanes; i++)
	{		
		std::string xline;
		getline(std::cin, xline);		
		std::string yline;
		getline(std::cin, yline);
		
		pointer[i].xcoord = stoi(xline);
		pointer[i].ycoord = stoi(yline);		
	}

	//Calculate the distance to every plane
	//and if they are inside your country shoot them
	for (int i = 0; i < numplanes; i++)
	{
		double distance = calcdistance(headquaters, pointer[i]);
		if (distance <= radius)
		{
			std::cout << "You destroyed a plane at [" << pointer[i].xcoord << "," << pointer[i].ycoord << "]" << std::endl;
		}
	}	
	return 0;
}