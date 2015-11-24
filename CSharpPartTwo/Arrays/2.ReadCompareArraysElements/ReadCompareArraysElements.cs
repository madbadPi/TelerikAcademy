using System;

class ReadCompareArraysElements
{
    static void Main(string[] args)
    {
        Console.Write("Number of elements of first array=");
        int firstArrayLength = int.Parse(Console.ReadLine());
        int[] firstArray = new int[firstArrayLength];
        for (int i = 0; i < firstArrayLength; i++)
        {
            Console.Write("firstArray[{0}]=", i);
            firstArray[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Number of elements of second array=");
        int secondArrayLength = int.Parse(Console.ReadLine());
        int[] secondArray = new int[secondArrayLength];
        for (int i = 0; i < secondArrayLength; i++)
        {
            Console.Write("secondArray[{0}]=", i);
            secondArray[i] = int.Parse(Console.ReadLine());
        }        
        bool isArraySame = true;
        if (firstArrayLength != secondArrayLength)
        {
            isArraySame = false;
        }
        else
        {
            for (int i = 0; i < firstArrayLength; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    isArraySame = false;
                    break;
                }
            }

        }
        if (isArraySame)
        {
            Console.WriteLine("The two arrays are with the same elements");
        }
        else
        {
            Console.WriteLine("The two arrays are not with the same elements");

        }
    }
}
