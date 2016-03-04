#include <iostream>
//using namespace std;

struct point
{
	int xccord;
	int ycoord;
};

double calcdistance(point first, point second)
{
	double result = 0;
	int x = pow(second.xccord - first.xccord, 2);
	int y = pow(second.ycoord - first.ycoord, 2);
	result = sqrt(x + y);
	return result;
}

int main()
{
	point firstpoint;
	firstpoint.xccord = -2;
	firstpoint.ycoord = -3;

	point secondpoint;
	secondpoint.xccord = -4;
	secondpoint.ycoord = 4;

	std::cout << "Distance between first and second poit is: " << calcdistance(firstpoint, secondpoint) << std::endl;
	return 0;
}