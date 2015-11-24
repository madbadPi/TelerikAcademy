using System;

class LongestSequenceInMatrix
{
    static int maxSum = 0;
    static string maxValue = "";
    static int[,] directions = { { 0, 1 }, { 1, 0 }, { 1, 1 }, { 1, -1 } };

    private static bool ContinueSearching(string[,] matrix, int row, int col)
    {
        bool ContinueSearching = false;
        if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
        {
            ContinueSearching = true;
        }
        return ContinueSearching;
    }  

    private static void SearchLongestSequence(string[,] matrix, bool[, ,] visited, int row, int col)
    {
        for (int direction = 0; direction < directions.GetLength(0); direction++)
        {
            if (!visited[row, col, direction])
            {
                int currentSum = 0;
                int currentRow = row;
                int currentCol = col;

                while (ContinueSearching(matrix, currentRow, currentCol) && matrix[row, col] == matrix[currentRow, currentCol])
                {
                    currentSum++;
                    visited[currentRow, currentCol, direction] = true;
                    currentRow += directions[direction, 0];
                    currentCol += directions[direction, 1];
                }

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    maxValue = matrix[row, col];
                }
            }
        }
    }

    private static void PrintMatrix(string[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, -6}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        //int rowLenN = int.Parse(Console.ReadLine());
        //int colLenM = int.Parse(Console.ReadLine());
        //string[,] matrix = new string[rowLenN, colLenM];
        //for (int row = 0; row < rowLenN; row++)
        //{
        //    for (int col = 0; col < colLenM; col++)
        //    {
        //        Console.Write("matrix[{0},{1}]=", row, col);
        //        matrix[row, col] = Console.ReadLine();
        //    }
        //}
        string[,] matrix = {
                            {"ha","fifi", "ho", "hii"},
                            {"fo", "ha", "hi", "a"},
                            {"xxx", "fi", "ha", "xx"},
                            {"ji", "ko" ,"ko", "ha"}
                           };
        PrintMatrix(matrix);
        bool[, , ] visited = new bool[matrix.GetLength(0), matrix.GetLength(1), directions.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                SearchLongestSequence(matrix, visited, i, j);
            }
        }
        Console.WriteLine(maxSum);
    }  
     
}
