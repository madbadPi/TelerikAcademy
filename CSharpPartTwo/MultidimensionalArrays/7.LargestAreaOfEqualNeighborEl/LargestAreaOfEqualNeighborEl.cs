using System;

class LargestAreaOfEqualNeighborEl
{
    static int currentSum = 0;    

    private static void Search(bool[,] arrayVisited, int[,] array, int row, int col, int currentValue)
    {

        if (row < 0 || col < 0 || row >= array.GetLength(0) || col >= array.GetLength(1))
        {
            return;
        }

        if (array[row, col] == currentValue && !arrayVisited[row, col])
        {
            currentSum++;
            arrayVisited[row, col] = true;
            Search(arrayVisited, array, row + 1, col, currentValue);
            Search(arrayVisited, array, row - 1, col, currentValue);
            Search(arrayVisited, array, row, col + 1, currentValue);
            Search(arrayVisited, array, row, col - 1, currentValue);
        }
    }

    static void Main()
    {
        int matrixRows = int.Parse(Console.ReadLine());
        int matrixCols = int.Parse(Console.ReadLine());
        int[,] matrix = new int[matrixRows, matrixCols];
        int maxSum = 0;
        //int[,] matrix = {
        //                   {1,0,2,2,2,4},
        //                   {3,3,3,2,2,4},
        //                   {4,1,1,2,2,2},
        //                   {2,2,2,2,3,1},
        //                   {4,1,3,3,1,1}
        //               };        
        bool[,] matrixVisited = new bool[matrix.GetLength(0), matrix.GetLength(1)];
        for (int row = 0; row < matrix.GetLength(0); row++)
		{
            for (int col = 0; col < matrix.GetLength(1); col++)
			{
                Console.Write("matrix[{0},{1}]=", row, col);
                matrix[row, col] = int.Parse(Console.ReadLine());
			}
		}                        
        int currentEl = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (!matrixVisited[row, col])
                {
                    currentSum = 0;
                    currentEl = matrix[row, col];
                    Search(matrixVisited, matrix, row, col, currentEl);
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum; 
                    }
                    //PrintMatrix(matrix);                    
                }
            }
        }
        Console.WriteLine(maxSum);
    }
   
}
