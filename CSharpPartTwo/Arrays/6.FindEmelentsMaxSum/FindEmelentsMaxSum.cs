using System;

class FindEmelentsMaxSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int[] array = new int[n];        
        int tempNum = 0;
        int maxSum = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write("array[{0}]=", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = n - 1; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    tempNum = array[j + 1];
                    array[j + 1] = array[j];
                    array[j] = tempNum;
                }
            }

        }
        if (n <= k)
        {
            for (int i = 0; i < n; i++)
            {
                maxSum += array[i];
            }
        }
        else
        {
            string stringBefore = "";
            for (int i = n - k; i < n; i++)
            {
                maxSum += array[i];
                Console.Write(stringBefore + array[i]);
                stringBefore = ", ";
            }
        }
        Console.WriteLine();
        Console.WriteLine(maxSum);
    }
}
