#include <iostream>
//using namespace std;

struct point
{
	int xcoord;
	int ycoord;
};

//point firstPoint ;

void move(point* currentPoint, int speed)
{
	currentPoint->xcoord += speed;
	currentPoint->ycoord += speed;
	//return currentPoint;
};

int main()
{	
	point firstPoint;
	firstPoint.xcoord = 0;
	firstPoint.ycoord = 0;
	//point newPoint = move(firstPoint, -12);
	move(&firstPoint, -12);
	std::cout << "point coordinates (" << firstPoint.xcoord << ", " << firstPoint.ycoord << ")" << std::endl;
	return 0;
}	