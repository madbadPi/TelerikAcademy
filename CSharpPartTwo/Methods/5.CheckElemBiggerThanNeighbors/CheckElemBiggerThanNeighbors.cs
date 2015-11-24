using System;

class CheckElemBiggerThanNeighbors
{
    private static bool IsBigger(int[] array, int index)
    {
        bool isBigger = false;
        if (index == 0 )
	    {
            if (array[index + 1] < array[index])
            {
                isBigger = true;
            }
        }
        else if (index == array.Length - 1)
        {
            if (array[index - 1] < array[index])
            {
                isBigger = true;
            }
        }
        else if (array[index - 1] < array[index] && array[index + 1] < array[index])
        {
            isBigger = true;
        }
        return isBigger;
    }
    
    static void Main()
    {
        Console.Write("Type the lenght of the array ");
        int arrLen = int.Parse(Console.ReadLine());
        //int[] arr = {15, 2, 3, 4, 1, 1, 5, 5, 6, -12, 100};
        int[] arr = new int[arrLen];
        for (int i = 0; i < arrLen; i++)
        {
            Console.Write("array[{0}]=", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Type the position of the element ");
        int index = int.Parse(Console.ReadLine());
        Console.WriteLine("The number is bigger - {0}", IsBigger(arr, index - 1));
    }    
}
