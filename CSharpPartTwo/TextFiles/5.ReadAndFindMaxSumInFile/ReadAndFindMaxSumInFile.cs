using System;
using System.Text;
using System.IO;

class ReadAndFindMaxSumInFile
{
    private static void WriteResult(int maxSum)
    {
        using (StreamWriter output = new StreamWriter("../../output.txt") )
        {
            output.WriteLine(maxSum);
        }
    }

    private static int GetMax(int[,] matrix)
    {
        int maxSum = 0;
        int currentSum = 0;

        for (int row = 0; row < matrix.GetLength(0) - 1 ; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1,col] + matrix[row + 1, col + 1];
                maxSum = Math.Max(maxSum, currentSum);
            }
        }
        return maxSum;
    }

    private static int[,] ReadMatrix()
    {
        using (StreamReader input = new StreamReader("../../test.txt"))
        {
            int len = int.Parse(input.ReadLine());
            int[,] matrix = new int[len, len];            
            for (int i = 0; i < len; i++)
            {
                string[] nums = input.ReadLine().Split(' ');
                for (int j = 0; j < len; j++)
                {
                    matrix[i, j] = int.Parse(nums[j]);
                }
            }
            return matrix;
        }        
    }

    static void Main()
    {
        int maxSum = GetMax(ReadMatrix());
        WriteResult(maxSum);
    }
}
