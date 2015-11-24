using System;

class BitBall
{
    static void Main()
    {
        int[,] gridT = new int[8, 8];
        int[,] gridB = new int[8, 8];
        string direction = "stop";
        int resultT = 0;
        int resultB = 0;
        int currentRow = 0;        
        for (int i = 0; i <= 7; i++)
        {
            int inputNum = int.Parse(Console.ReadLine());
            for (int j = 0; j <= 7; j++)
            {
                int mask = 1 << j;
                int result = (mask & inputNum) >> j;
                gridT[i,j] = result;
            }
        }
        for (int i = 0; i <= 7; i++)
        {
            int inputNum = int.Parse(Console.ReadLine());
            for (int j = 0; j <= 7; j++)
            {
                int mask = 1 << j;
                int result = (mask & inputNum) >> j;
                gridB[i,j] = result;
            }
        }
        for (int i = 0; i <= 7; i++)
        {
            for (int j = 0; j <=7; j ++)
            {
                if((gridT[i,j] == 1) && (gridB[i,j] == 1))
                {
                    gridT[i, j] = 0;
                    gridB[i, j] = 0;
                }
        
            }
        }
        for (int i = 0; i <= 7; i++)
        {
            for (int j = 0; j <= 7; j++)

            {
                currentRow = i;
                while (true)
                {
                    if (currentRow + 1 > 7)
                    {
                        if (gridT[i, j] == 1)
                        {
                            resultT++;
                        }                        
                        direction = "stop";
                    }
                    else
                    {
                        if (gridT[i, j] == 1 && (gridB[currentRow + 1, j] != 0 || gridT[currentRow + 1, j] != 0))
                        {
                            direction = "stop";
                        }
                        else if (gridT[i, j] == 1 && (gridB[currentRow + 1, j] == 0 && gridT[currentRow + 1, j] == 0))
                        {
                            direction = "down";
                        }  
                    }

                    if (direction == "down")
                    {
                        currentRow++;
                    }
                    if (direction == "stop")
                    {
                        break;
                    }
                }
                
            }
        }

        for (int i = 0; i <= 7; i++)
        {
            for (int j = 0; j <= 7; j++)
            {
                currentRow = i;
                while (true)
                {
                    if (currentRow - 1 < 0)
                    {
                        if (gridB[i, j] == 1)
                        {
                            resultB++;
                        }
                        direction = "stop";
                    }
                    else
                    {
                        if (gridB[i, j] == 1 && (gridB[currentRow - 1, j] != 0 || gridT[currentRow - 1, j] != 0))
                        {
                            direction = "stop";
                        }
                        else if (gridB[i, j] == 1 && (gridB[currentRow - 1, j] == 0 && gridT[currentRow - 1, j] == 0))
                        {
                            direction = "up";
                        }
                    }
                    if (direction == "up")
                    {
                        currentRow--;
                    }
                    if (direction == "stop")
                    {
                        break;
                    }
                }

            }
        }
        Console.WriteLine(resultT + ":" + resultB);
    }
}
