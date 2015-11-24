using System;
using System.Collections.Generic;

class ConvertDecimalToBin
{
    private static void Print(List<int> list)
    {
        for (int i = list.Count - 1; i >= 0; i--)
        {
            Console.Write(list[i]);
        }
        Console.WriteLine();
    }

    private static void ConvertDecimalToBinary(List<int> list, int inputNum)
    {
        while(inputNum > 0)
        {
            list.Add(inputNum & 1);
            inputNum = inputNum >> 1;
        }
    }

    static void Main()
    {
        int inputNum = int.Parse(Console.ReadLine());
        List<int> result = new List<int>();
        ConvertDecimalToBinary(result, inputNum);
        Print(result);
    }
}
