using System;

class ArrayBinSearch
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("arr[{0}]=", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        InsertionSort(arr);
        FindNumComparedWithK(arr, k);
    }

    private static void FindNumComparedWithK(int[] array, int inputK)
    {
        int index = Array.BinarySearch(array, inputK);
        if (index >= 0)
        {
            Console.WriteLine("The largest number in the array which is <= {0} is {1}", inputK, array[index]);
        }         
        else if (index <=-2 && index >= -(array.Length + 1))
        {
            Console.WriteLine("The largest number in the array which is <= {0} is {1}", inputK, array[-index - 2]);
        }
        else if (index == -1)
        {
            Console.WriteLine("There is no number in the array that is <= {0}", inputK);
        }          
    }

    private static void InsertionSort(int[] array)
    {
        int tempValue = 0;
        int j = 0;
        for (int i = 1; i < array.Length; i++)
        {
            tempValue = array[i];
            j = i - 1;
            while (j>=0 && array[j] > tempValue)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = tempValue;
        }
    }
}