using System;
using System.Data.Linq;

class Sheet
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string nBin = Convert.ToString(n, 2);
        int numbers = nBin.Length;
        int[] bit = new int[11];
        for (int i = 0; i < numbers; i++)
        {
            int mask = 1 << i;
            bit[i] = (mask & n) >> i;
        }
        for (int i = 0; i <= 10; i++)
        {
            if (bit[i] == 0)
            {
                int indexA = 10 - i;
                Console.WriteLine("A {0}", indexA);
            }
        }
    }
}
