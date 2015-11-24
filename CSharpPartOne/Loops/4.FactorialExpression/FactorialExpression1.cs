using System;
using System.Numerics;

class FactorialExpression1
{
    static void Main()
    {
        int n, k;
        BigInteger factorial = 1;
        string consoleInput;
        do
        {
            Console.Write("Enter valid number n=");
            consoleInput = Console.ReadLine();
        }
        while (!int.TryParse(consoleInput, out n) || n <= 1);
        do
        {
            Console.Write("Enter valid number k=");
            consoleInput = Console.ReadLine();
        }
        while (!int.TryParse(consoleInput, out k) || (k < 1) || (k >= n));
        for (int i = k + 1; i <= n; i++)
        {
            factorial *= i;
        }
        Console.WriteLine("The result of N!/K! for 1<K<N is : {0}", factorial);
    }
}
