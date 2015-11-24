using System;

class CombinationofElements
{

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

    private static void Permutate(int[] array, int first, int last)
    {
        if (first == last)
        {
            PrintArray(array);
        }
        else if (first < last)
        {
            for (int i = first; i < array.Length; i++)
            {
                SwapElem(ref array[first], ref array[i]);
                Permutate(array, first + 1, last);
                SwapElem(ref array[first], ref array[i]);
            }
        }

    }

    private static void SwapElem(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arrNums = new int[n];
        for (int i = 0; i < n; i++)
        {
            arrNums[i] = i + 1;
        }
        Permutate(arrNums, 0, arrNums.Length-1);
    }
}

