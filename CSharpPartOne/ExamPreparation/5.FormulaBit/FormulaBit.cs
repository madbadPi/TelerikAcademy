using System;
using System.Collections.Generic;

class FormulaBit
{
    static void Main()
    {
        int[,] grid = new int[8,8];
        int currentRow = 0;
        int currentCol = 7;
        string direction = "down";
        string pastDirection = "down";
        bool exitFound = false;
        int track = 0;
        int turn = 0;
        for (int i = 0; i <= 7; i++)
		{
            int inputNum = int.Parse(Console.ReadLine());
            for (int j = 0; j <= 7; j++)
            {
                int mask = 1 << j;
                int result = (mask & inputNum) >> j;
                grid[i,7-j] = result;
            }

		}
        while(true)
        {              
            if (grid[currentRow,currentCol] == 1 )
            {
                break;
            }
            track++;
            if (currentCol == 0 && currentRow == 7)
            {
                exitFound = true;
                break;
            }
            if (direction == "down" && (currentRow + 1 >7 || grid[currentRow + 1, currentCol] !=0))
            {
                direction = "left";
                pastDirection = "down";
                turn++;
                if ((currentCol - 1 < 0) || grid[currentRow, currentCol-1] == 1)
                {
                    break;
                }

            }
            else if (direction == "left" && pastDirection == "down" && (currentCol-1 < 0 || grid[currentRow, currentCol-1] != 0))
            {
                direction = "up";
                turn++;
                if ((currentRow - 1 < 0)||grid[currentRow-1, currentCol]==1)
                {
                    break;    
                }

            }
            else if (direction == "left" && pastDirection == "up" && (currentCol - 1 < 0 || grid[currentRow, currentCol - 1] != 0))
            {
                direction = "down";
                turn++;
                if ((currentRow + 1 > 7) || grid[currentRow + 1, currentCol] == 1)
                {
                    break;
                }

            }
            else if (direction == "up" && (currentRow -1 < 0 || grid[currentRow - 1, currentCol] != 0))
            {
                direction = "left";
                pastDirection = "up";
                turn++;
                if ((currentCol -1 < 0) || grid[currentRow, currentCol -1] == 1)
                {
                    break;
                }
            }                                   
            if (direction == "down")
            {
                currentRow++;
            }
            else if (direction == "left")
            {
                currentCol--; 
            }
            else if (direction == "up")
            {
                currentRow--;
            }
            
            
        }                
        if (exitFound)
        {
            Console.WriteLine(track + " " +turn);
        }
        else
        {
            Console.WriteLine("No " + track);
        }

    }
}