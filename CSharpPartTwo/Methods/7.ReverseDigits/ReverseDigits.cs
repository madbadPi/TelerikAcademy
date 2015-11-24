using System;
using System.Collections.Generic;

class ReverseDigits
{
    private static void PrintDidigts(List<int> numArr)
    {
        foreach (int num in numArr)
        {
            Console.Write(num);
        }
        Console.WriteLine();
    }

    private static void ReverseDigitsOfNum(List<int> numArr, int inputNum)
    {
        int counter = 0;
        int lastNum = 0;
        while (inputNum / 10 != 0)
        {
            lastNum = inputNum - (inputNum / 10) * 10;
            numArr.Add(lastNum);
            counter++;
            inputNum = (inputNum - lastNum) / 10;
        }
        numArr.Add(inputNum);
    }

    static void Main()
    {
        int inputNum = int.Parse(Console.ReadLine());
        List<int> numArr = new List<int>();
        ReverseDigitsOfNum(numArr, inputNum);
        PrintDidigts(numArr);
    }
}
