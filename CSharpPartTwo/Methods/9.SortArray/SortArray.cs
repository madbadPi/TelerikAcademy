using System;

class SortArray
{
    private static void PrintArr(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("{0} ", arr[i]);
        }
    }

    private static void SortArr(int[] arr, bool descending)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Swap(arr, i, FindMaxNumIndex(arr, i, descending));
        }
    }

    private static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    private static int FindMaxNumIndex(int[] arr, int startIndex, bool descending)
    {
        int maxNumIndex = startIndex;
        for (int i = startIndex; i < arr.Length; i++)
        {
            if (descending && arr[i] > arr[maxNumIndex])
            {
                maxNumIndex = i;
            }
            else if (!descending && arr[i] < arr[maxNumIndex])
            {
                maxNumIndex = i;
            }
        }
        return maxNumIndex;
    }

    static void Main()
    {
        int[] array = { 1, 2, -12, 56, 1, 2, 5, 6, 6, 4 };
        int startIndex = int.Parse(Console.ReadLine());
        bool descending = true;
        SortArr(array, descending); // sort in descending order
        PrintArr(array);
        Console.WriteLine();
        descending = false; // sort in ascending order
        SortArr(array, descending);
        PrintArr(array);
    }
}
