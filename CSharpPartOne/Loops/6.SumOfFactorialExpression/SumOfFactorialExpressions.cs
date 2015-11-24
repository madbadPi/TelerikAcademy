using System;
using System.Numerics;

class SumOfFactorialExpressions
{
    static void Main()
    {
        int n;
        int x;        
        string consoleInput;
        do
        {
            Console.Write("Enter valid number n=");
            consoleInput = Console.ReadLine();
        }
        while (!int.TryParse(consoleInput, out n) || n < 1);
        do
        {
            Console.Write("Enter valid number x=");
            consoleInput = Console.ReadLine();
        }
        while (!int.TryParse(consoleInput, out x) || x == 0);
        double factorial = 1;
        double sum = 1;
        double powerOfX = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            powerOfX *= x;
            sum += factorial / powerOfX;            
            Console.WriteLine("{0}, {1}, {2}", factorial, powerOfX, sum);
        }
        Console.WriteLine(sum);
    }
}
