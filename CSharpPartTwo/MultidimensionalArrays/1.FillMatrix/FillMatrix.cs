using System;

class FillMatrix
{
    static void Main(string[] args)
    {
        Console.Write("Enter the matrix size N = ");
        int sizeN = int.Parse(Console.ReadLine());
        int[,] matrix = new int[sizeN, sizeN];        
        int currentEl = 1;

        //a
        for (int col = 0; col < sizeN; col++)        
        {
            for (int row = 0; row < sizeN; row++)
            {
                matrix[row, col] = currentEl;
                currentEl++;
            }
        }
        MatrixPrint(matrix);
        currentEl = 1;
        //b
        for (int col = 0; col < sizeN; col++)
        {
            if (col % 2 == 0)
            { 
                for (int row = 0; row < sizeN; row++)
                {
        
                        matrix[row, col] = currentEl;
                        currentEl++;
                }
            }
            else
            {
                for (int row = sizeN-1; row >= 0; row--)
                {
        
                    matrix[row, col] = currentEl;
                    currentEl++;
                }
            } 
        }
        MatrixPrint(matrix);
        currentEl = 1;
        //c
        for (int i = 0; i < sizeN; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                matrix[sizeN - i + j - 1, j] = currentEl++;
            }
        }       
        
        for (int i = sizeN - 2; i >= 0; i--)
        {
            for (int j = i; j >= 0; j--)
            {
                matrix[i - j, sizeN - j - 1] = currentEl++;
            }
        }
        MatrixPrint(matrix);
        currentEl = 1;
        //d
        int start = 0;
        int end = sizeN;
        do
        {
            for (int i = start; i < end; i++)
            {
                matrix[i, start] = currentEl;
                currentEl++;
            }
            for (int j = start+1; j < end; j++)
            {
                matrix[end - 1, j]= currentEl;
                currentEl++;
            }
            for (int k = end - 2; k >= start; k--)
			{
                matrix[k, end - 1] = currentEl;
                currentEl++;			 
			}
            for (int p = end - 2; p > start; p--)
            {
                matrix[start, p] = currentEl;
                currentEl++;
            }
            start++;
            end--;
        } while (start < end);
        
        MatrixPrint(matrix);
    }

    private static void MatrixPrint(int[,] matrix)
    {
        Console.WriteLine();
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, 4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}
     