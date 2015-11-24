using System;
using System.Numerics;

class PrintFibonacciFirst100
{
    static void Main()
    {
        BigInteger fibonacciFirst = 0;
        Console.WriteLine(fibonacciFirst);
        BigInteger fibonacciSecond = 1;
        Console.WriteLine(fibonacciSecond);
        BigInteger fibonacciN = fibonacciFirst + fibonacciSecond;
        Console.WriteLine(fibonacciN);
        for (int i = 3; i <= 100 ; i++)
        {
            fibonacciFirst = fibonacciSecond;
            fibonacciSecond = fibonacciN;
            fibonacciN = fibonacciFirst + fibonacciSecond;
            Console.WriteLine(fibonacciN);
        }
    }
}
