using System;

class CombinationofElements
{
    private static void GenerateCombination(int[] array, int index, int n, int next)
    {
        if (index == array.Length)
        {
            PrintCombination(array);
        }
        else
        {
            for (int i = next; i <= n; i++)
            {
                array[index] = i;
                GenerateCombination(array, index + 1, n, i + 1);
            }
        }
    }

    private static void PrintCombination(int[] array)
    {
        string beforeNum = "";
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(beforeNum + array[i]);
            beforeNum = ", ";
        }
        Console.WriteLine();
        beforeNum = "";
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int[] combination = new int[k];
        GenerateCombination(combination, 0, n, 1);
    }
}
