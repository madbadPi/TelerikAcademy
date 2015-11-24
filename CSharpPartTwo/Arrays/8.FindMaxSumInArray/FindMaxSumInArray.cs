using System;

class FindMaxSumInArray
{
    static void Main()
    {
        int arrayLength = int.Parse(Console.ReadLine());
        int[] array = new int[arrayLength];
        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write("array[{0}]=", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        int tempSum = 0;
        int maxSum = 0;
        for (int i = 0; i < arrayLength; i++)
        {
            tempSum += array[i];
            if (tempSum > maxSum)
            {
                maxSum = tempSum;         
            }
            if (tempSum < 0)
            {
                tempSum = 0;
            }
        }
        Console.Write("Sum={0}", maxSum);       

    }
}
