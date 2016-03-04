#include <iostream>
#include <string>
#include <vector>

int main()
{
	std::string numberstr;
	std::cout << "Input a number ";
	getline(std::cin, numberstr);
	int num = stoi(numberstr);
	std::vector<std::vector<int>> matrix(num, std::vector<int>(num));

	int row = num-1;
	int col = num-1;
	int currentrow = 0;
	int currentcol = 0;	
	int counter = 1;
	int maxnum = num*num;
	std::string direction = "right";
	while (counter <= num*num)
	{
		//if there is already a number written in the matrix in that direction
		if (direction == "right" && matrix[currentrow][currentcol] != 0)
		{
			//go back and change the direction
			currentcol--;
			currentrow++;
			direction = "down";
		}
		//if it is reached the end of the matrix in that direction
		else if (direction == "right" && currentcol >= col)
		{	
				matrix[currentrow][currentcol] = counter;
				direction = "down";
		
		}
		//if there is already a number written in the matrix in that direction
		else if (direction == "down" && matrix[currentrow][currentcol] != 0)
		{
			//go back and change the direction
			currentcol--;
			currentrow--;
			direction = "left";
		}
		//if it is reached the end of the matrix in that direction
		else if (direction == "down" && currentrow >= row)
		{

			matrix[currentrow][currentcol] = counter;
			direction = "left";

		}
		//if there is already a number written in the matrix in that direction
		else if (direction == "left" && matrix[currentrow][currentcol] != 0)
		{
			//go back and change the direction
			currentcol++;
			currentrow--;
			direction = "up";
		}
		//if it is reached the end of the matrix in that direction
		else if (direction == "left" && currentcol <= 0)
		{
			matrix[currentrow][currentcol] = counter;
			direction = "up";

		}
		//if there is already a number written in the matrix in that direction
		else if (direction == "up" && matrix[currentrow][currentcol] != 0)
		{
			//go back and change the direction
			currentrow++;
			currentcol++;
			direction = "right";
		}
		//if it is reached the end of the matrix in that direction
		else if (direction == "up" && currentrow <= 0)
		{
			matrix[currentrow][currentcol] = counter;
			direction = "right";

		}

		//directions
		if (direction == "left")
		{
			matrix[currentrow][currentcol] = counter;
			currentcol--;
		}
		else if (direction == "down")
		{
			matrix[currentrow][currentcol] = counter;
			currentrow++;
		}
		else if (direction == "up")
		{
			matrix[currentrow][currentcol] = counter;
			currentrow--;
		}
		else if (direction == "right")
		{
			matrix[currentrow][currentcol] = counter;
			currentcol++;
		}
		
		counter++;			
	}

	//print matrix
	for (int i = 0; i <= row; i++)
	{
		for (int j = 0; j <= col; j++)
		{
			std::cout <<" " <<matrix[i][j];
		}
		std::cout << std::endl;
	}
	std::cout << std::endl;
	return 0;
}