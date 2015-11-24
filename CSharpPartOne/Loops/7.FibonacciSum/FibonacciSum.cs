using System;

class FibonacciSum
{
    static void Main(string[] args)
    {
        int n;
        Console.Write("Enter valid number n=");
        n = int.Parse(Console.ReadLine());
        int fibonacciFirst = 0;
        int fibonacciSecond = 1;
        int fibonacciN;
        int fibonacciSum = 1;
        Console.WriteLine(fibonacciFirst);
        Console.WriteLine(fibonacciSecond);
        for (int i = 2; i < n; i++)
        {
            fibonacciN = fibonacciFirst + fibonacciSecond;
            fibonacciFirst = fibonacciSecond;
            fibonacciSecond = fibonacciN;
            Console.WriteLine(fibonacciN);
            fibonacciSum += fibonacciN;
        }
        Console.WriteLine("The sum of the first N members of the sequence of Fibonacci is : {0}", fibonacciSum);
    }
}
