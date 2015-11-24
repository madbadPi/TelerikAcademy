using System;

class MaxSumOfElements
{
    private static int SumSurroundingElements(int[,] subMatrix, int row, int col)
    {
        int sum = 0;
        for (int i = row - 1; i <= row + 1; i++)
        {
            for (int j = col - 1; j <= col + 1; j++)
            {
                sum += subMatrix[i, j];
            }
        }
        return sum;
    }
    static void Main()
    {
        int rowLenN = int.Parse(Console.ReadLine());
        int colLenM = int.Parse(Console.ReadLine());
        int[,] matrix = new int[rowLenN, colLenM];
        
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("matrix[{0},{1}]=", row, col);
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, 3}", matrix[row, col]);
            }
            Console.WriteLine();
        }

        int currentRow = 0;
        int currentCol = 0;
        int currentSum = 0;
        int maxSum = 0;
        for (int row = 1; row < rowLenN - 1; row++)
        {
            for (int col = 1; col < colLenM -1; col++)
            {
                currentRow = row;
                currentCol = col;
                currentSum = SumSurroundingElements(matrix, currentRow, currentCol);
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }
        }
        Console.WriteLine(maxSum);
    }
}
