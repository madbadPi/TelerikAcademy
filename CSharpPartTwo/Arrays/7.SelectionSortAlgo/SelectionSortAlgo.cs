using System;

class SelectionSortAlgo
{
    static void Main()
    {
        int arrayLength = int.Parse(Console.ReadLine());
        int[] array = new int[arrayLength];
        int tempNum = 0;
        int minPos = 0;
        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write("array[{0}]=", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arrayLength - 1; i++)
        {
            minPos = i;
            for (int j = i + 1; j < arrayLength; j++)
            {
                if (array[j] < array[minPos])
                {
                    minPos = j;
                }
            }

            if (i != minPos)
            {
                tempNum = array[i];
                array[i] = array[minPos];
                array[minPos] = tempNum;
            }
        }
        Console.WriteLine("The sort array with selection sort algorithm is:");
        for (int i = 0; i < arrayLength; i++)
        {
            Console.WriteLine("array[{0}]={1}", i, array[i]);
        }
    }
}
