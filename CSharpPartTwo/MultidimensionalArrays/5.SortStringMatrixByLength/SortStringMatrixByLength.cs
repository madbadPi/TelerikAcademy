using System;
using System.Collections.Generic;

class SortStringMatrixByLength
{   
    private static void SortMatrixByRowLen(string[] matrixString)
    {
        for (int row = 1; row < matrixString.GetLength(0); row++)
        {
            int tempLen = matrixString[row].Length;
            string tempString = matrixString[row];
            int prevRow = row - 1;
            while ((prevRow >= 0) && (matrixString[prevRow].Length > tempLen))
            {
                matrixString[prevRow + 1] = matrixString[prevRow];
                prevRow--;
            }
            matrixString[prevRow + 1] = tempString;
        }
    }

    private static void PrintMatrix(string[] matrixString)
    {
        for (int row = 0; row < matrixString.GetLength(0); row++)
        {
            Console.WriteLine(matrixString[row]);
        }
    }

    static void Main()
    {
        int len = int.Parse(Console.ReadLine());
        string[] matrixString = new string[len];
        for (int i = 0; i < matrixString.GetLength(0); i++)
        {
            matrixString[i] = Console.ReadLine();
        }

        SortMatrixByRowLen(matrixString);
        PrintMatrix(matrixString);
    }

}