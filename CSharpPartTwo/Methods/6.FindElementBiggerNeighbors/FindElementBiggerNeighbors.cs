using System;

class FindElementBiggerNeighbors
{
    static void Main()
    {
        Console.Write("Type the lenght of the array ");
        int arrLen = int.Parse(Console.ReadLine());
        //int[] arr = {20, 2, 3, 4, 5, 6, 100};
        int[] arr = new int[arrLen];
        for (int i = 0; i < arrLen; i++)
        {
            Console.Write("array[{0}]=", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        int index = IndexOfBiggerElement(arr);
        if (index != -1)
	    {
	    	 Console.WriteLine("The index of the first element in the array that is bigger than its neighbors is {0}", index);
	    }
        else 
        {
            Console.WriteLine("There is no element ");
        }
    }

    private static bool IsBigger(int[] array, int index)
    {
        bool isBigger = false;
        if (array[index - 1] < array[index] && array[index + 1] < array[index])
        {
            isBigger = true;
        }
        return isBigger;
    }

    private static int IndexOfBiggerElement(int[] array)
    {        
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (IsBigger(array, i))
            {
                return i;
            }
        }
        return -1;
    }
}