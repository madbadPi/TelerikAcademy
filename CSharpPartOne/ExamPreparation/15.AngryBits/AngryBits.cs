using System;

class AngryBits
{
    static void Main()
    {
        int[,] grid = new int[8, 16];
        string direction = "upwards";
        int point = 0;
        int currentRow = 0;
        int currentCol = 8;
        string winFlag = "Yes";
        int path = 0;
        int currentResult = 0;
        for (int i = 0; i <= 7; i++)
        {
            int inputNum = int.Parse(Console.ReadLine());
            for (int j = 0; j <= 15; j++)
            {
                int mask = 1 << j;
                int result = (mask & inputNum) >> j;
                grid[i, j] = result;
            }
        }
        int row = currentRow;

        for (int col = 8; col <= 15; col++)
        {
            currentCol = col;        
            while (true)
            {
                
                if (grid[row,col] == 1)
                {
                    if (row == 0)
                    {
                        direction="downwards";
                    }
                    //else
                    //{
                    //    direction = "upwards";
                    //}

                    if (direction == "upwards" && currentRow - 1 < 0 && grid[currentRow, currentCol] != 1)
                    {
                        direction = "downwards";
                    }
                    if (direction == "downwards" && currentRow + 1 > 7 && grid[currentRow, currentCol] != 1)
                    {
                        direction = "stop";
                    }
                    if (direction == "downwards" && currentCol + 1 < 0 && grid[currentRow, currentCol] != 1)
                    {
                        direction = "stop";
                    }
                    if (direction == "upwards" && grid[currentRow - 1, currentCol - 1] == 1)
                    {

                        point++;                        
                        grid[currentRow - 1, currentCol - 1] = 0;
                        direction = "stop";
                        bool borderFlagUp = false;
                        bool borderFlagRight = false;
                        if (currentRow -1 <= 0)
                        {
                            borderFlagUp = true;
                        }
                        if (currentCol - 1 <= 0)
                        {
                            borderFlagRight = true;
                        }
                        if (grid[currentRow, currentCol - 1]==1)
                        {
                            point++;
                            grid[currentRow, currentCol - 1] = 0;
                        }
                        if (!borderFlagRight && grid[currentRow, currentCol - 2]==1)
                        {
                            point++;
                            grid[currentRow, currentCol - 2] = 0;
                        }
                        if (grid[currentRow - 1, currentCol] == 1)
                        {
                            point++;
                            grid[currentRow - 1, currentCol] = 0;
                        }
                        if (!borderFlagRight && grid[currentRow - 1, currentCol - 2] == 1)
                        {
                            point++;
                            grid[currentRow - 1, currentCol - 2] = 0;
                        }
                        if (!borderFlagUp && grid[currentRow -2, currentCol] == 1)
                        {
                            point++;
                            grid[currentRow - 2, currentCol] = 0;
                        }
                        if (!borderFlagUp && grid[currentRow - 2, currentCol - 1] == 1)
                        {
                            point++;
                            grid[currentRow - 2, currentCol - 1] = 0;
                        }
                        if (!borderFlagUp && !borderFlagRight && grid[currentRow - 2, currentCol - 2] == 1)
                        {
                            point++;
                            grid[currentRow - 2, currentCol - 2] = 0;
                        }
                        //
                        currentResult += (path + 1) * point;
                        path = 0;
                        point = 0;
                        grid[row, col] = 0;
                    }
                    //if (direction == "downwards" && grid[currentRow - 1, currentCol - 1] == 1)
                    //{
                    //    point++;
                    //    direction = "stop";
                    //}
                    
                    if (direction == "downwards" && grid[currentRow + 1, currentCol - 1] == 1)
                    {
                        point++;
                        direction = "stop";
                        grid[currentRow + 1, currentCol - 1] = 0;
                        bool borderFlagDown = false;
                        bool borderFlagRight = false;
                        if (currentRow +1 >= 7)
                        {
                            borderFlagDown = true;
                        }
                        if (currentCol -1 <= 0)
	                    {
		                    borderFlagRight = true;
	                    }

                        if (grid[currentRow, currentCol - 1] == 1)
                        {
                            point++;
                            grid[currentRow, currentCol - 1] = 0;
                        }
                        if (!borderFlagRight && grid[currentRow, currentCol - 2] == 1)
                        {
                            point++;
                            grid[currentRow, currentCol - 2] = 0;
                        }
                        if (grid[currentRow + 1, currentCol] == 1)
                        {
                            point++;
                            grid[currentRow + 1, currentCol] = 0;
                        }
                        if (!borderFlagRight && grid[currentRow + 1, currentCol - 2] == 1)
                        {
                            point++;
                            grid[currentRow + 1, currentCol - 2]=0;
                        }
                        if (!borderFlagDown && grid[currentRow + 2, currentCol] == 1) 
                        {
                            point++;
                            grid[currentRow + 2, currentCol] = 0;
                        }
                        if (!borderFlagDown && grid[currentRow + 2, currentCol - 1] == 1)
                        {
                            point++;
                            grid[currentRow + 2, currentCol - 1] = 0;
                        }
                        if (!borderFlagRight && !borderFlagDown && grid[currentRow + 2, currentCol - 2] == 1 )
                        {
                            point++;
                            grid[currentRow + 2, currentCol - 2] = 0;
                        }
                        currentResult += (path + 1) * point;
                        path = 0;
                        point = 0;
                        grid[row, col] = 0;
                    }            
                    if (direction == "downwards")
                    {
                        currentRow++;
                        currentCol--;
                        path++;
                    }
                    if (direction == "upwards")
                    {
                        currentRow--;
                        currentCol--;
                        path++;
                    }
                    if (direction == "stop")
                    {
                        direction = "upwards";
                        break;
                    }
                }
                else if (row < 7)
                {
                    row++;
                    currentRow = row;
                }
                else
                {
                    row = 0;
                    break;
                }
                
            }
        }
        for (int i = 0; i <= 7; i++)
        {
            for (int j = 0; j <= 7; j++)
            {
                if (grid[i,j] == 1)
                {
                    winFlag = "No";
                    break;
                }
            }
        }

        Console.WriteLine("{0} {1}", currentResult, winFlag);
    }
}
