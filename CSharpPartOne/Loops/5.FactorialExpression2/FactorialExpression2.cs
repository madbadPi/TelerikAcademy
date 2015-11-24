using System;
using System.Numerics;

class FactorialExpression2
{
    static void Main()
    {
        int n, k;
        BigInteger factorialN = 1;
        BigInteger factorialExpression = 1;
        string consoleInput;
        do
        {
            Console.Write("Enter valid number k=");
            consoleInput = Console.ReadLine();
        }
        while (!int.TryParse(consoleInput, out k) || k <= 1);
        do
        {
            Console.Write("Enter valid number n=");
            consoleInput = Console.ReadLine();
        }
        while (!int.TryParse(consoleInput, out n) || (n < 1) || (n >= k));
        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
        }
        for (int j = k - n + 1; j <= k; j++)
        {
            factorialExpression *= j;
        }
        Console.WriteLine("the result of N!*K! / (K-N)! for given N and K (1<N<K) is {0}", factorialN * factorialExpression);
    }
}
