using System;

class Variation
{
    private static void GenerateVariation(int[] array, int index, int n)
    {
        if (index == array.Length)
        {
            PrintArray(array); 
        }
        else
        {
            for (int i = 1; i <=n ; i++)
            {
                array[index] = i;
                GenerateVariation(array, index + 1, n);
            }
        }
    }

    private static void PrintArray(int[] array)
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
        int[] variation = new int[k];
        GenerateVariation(variation, 0, n);
    }
}
