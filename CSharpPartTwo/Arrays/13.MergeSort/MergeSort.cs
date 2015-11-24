using System;

class MergeSort
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        int[] numbersArray = new int[length];
        for (int i = 0; i < length; i++)
        {
            Console.Write("a[{0}]=", i);
            numbersArray[i] = int.Parse(Console.ReadLine());
        }
        MergeSortRec(numbersArray);
        for (int j = 0; j < length; j++)
        {
            Console.WriteLine("a[{0}]={1}", j, numbersArray[j]);
        }
    }

    static public void MergeSortRec(int[] numbersArray)
    {
        if (numbersArray.Length < 2)
        {
            return;
        }
        int mid = numbersArray.Length / 2;
        int[] left = new int[mid];
        int[] right = new int[numbersArray.Length - mid];
        for (int i = 0; i < mid; i++)
        {
            left[i] = numbersArray[i];
        }
        for (int j = mid; j < numbersArray.Length; j++)
        {
            right[j - mid] = numbersArray[j];
        }

        MergeSortRec(left);
        MergeSortRec(right);
        MergeSortOnly(left, right, numbersArray);
    }
    
    static public void MergeSortOnly(int[] left, int[] right, int[] numbersArray)
    {
        int i = 0;
        int k = 0;
        int j = 0;
        int nL = left.Length;
        int nR = right.Length;
        while (i < nL && j < nR)
        {
            if (left[i] <= right[j])
            {
                numbersArray[k] = left[i];
                k++;
                i++;
            }
            else
            {
                numbersArray[k] = right[j];
                k++;
                j++;
            }
        }
        while (i < nL)
        {
            numbersArray[k] = left[i];
            i++; 
            k++;
        }
        while (j < nR)
        {
            numbersArray[k] = right[j];
            j++;
            k++;
        }
    }
}
