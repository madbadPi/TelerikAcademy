using System;
using System.Numerics;

class TrailingZeroFactorialNums
{
    static void Main()
    {
        Console.Write("Enter number n=");
        int n = int.Parse(Console.ReadLine());
        BigInteger factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        int TrailingZero = 0;        
        for (int i = 5; n / i >= 1; i *= 5)
        {
            TrailingZero += n / i;
        }
        
        Console.WriteLine("The trailing zero at the end of {0}!={1} -> {2}", n, factorial, TrailingZero);
    }
}
