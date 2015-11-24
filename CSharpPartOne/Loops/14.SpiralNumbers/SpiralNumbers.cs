using System;

class SpiralNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] spiral = new int[20, 20];
        int start = 0;
        int end = n;
        int counter = 1;
        if (n >= 20 || n <= 0)
        {
            Console.WriteLine("error");
        }
        else
        {
            while (end - start >= 1)
            {
                for (int i = start; i < end; i++)
                {
                    spiral[start, i] = counter;
                    counter++;
                }
                for (int j = start + 1; j < end; j++)
                {
                    spiral[j, end - 1] = counter;
                    counter++;
                }
                for (int k = end - 2; k >= start; k--)
                {
                    spiral[end - 1, k] = counter;
                    counter++;
                }
                for (int l = end - 2; l >= start + 1; l--)
                {
                    spiral[l, start] = counter;
                    counter++;
                }
                start++;
                end--;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == n - 1)
                    {
                        Console.Write(spiral[i, j]);
                    }
                    else
                    {
                        Console.Write(spiral[i, j] + "\t");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
