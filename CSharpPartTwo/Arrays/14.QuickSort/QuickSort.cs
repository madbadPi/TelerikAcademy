using System;

class QuickSort
{
    static void Main()
    {
        int len = int.Parse(Console.ReadLine());
        int[] array = new int[len];
        for (int i = 0; i < len; i++)
        {
            Console.Write("a[{0}]=", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        int start = 0;
        int end = len-1;
        QuickSortRec(array, start, end);
        for (int j = 0; j < len; j++)
        {
            Console.WriteLine("a[{0}]={1}", j, array[j]);
        }
    }

    private static void QuickSortRec(int[] array, int start, int end)
    {
        if (start >= end)
        {
            return;
        }
        int partIndex = Partition(array, start, end);
        QuickSortRec(array, start, partIndex - 1);
        QuickSortRec(array, partIndex + 1, end);
    }

    private static int Partition(int[] array,int start,int end)
    {
        int partIndex = start;
        int pivot = array[end];
        int temp;
        for (int i = start; i < end; i++)
        {
            if (array[i] <= pivot)
            {
                temp = array[i];
                array[i] = array[partIndex];
                array[partIndex] = temp;                
                partIndex++;
            }            
        }
        temp = array[partIndex];
        array[partIndex] = array[end];
        array[end] = temp;
        return partIndex; 
    }
}
