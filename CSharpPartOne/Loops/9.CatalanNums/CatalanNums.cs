using System;
using System.Numerics;

class CatalanNums
{
    static void Main()
    {
        Console.Write("Enter valid number n=");
        int n = int.Parse(Console.ReadLine());
        BigInteger factorialExpression1=1;
        BigInteger factorialExpression2=1;
        BigInteger catalanNum=1;
        if (n < 0)
        {
            Console.WriteLine("Invalid input!");
            return;
        }
        if (n == 0 || n == 1)
        {
            Console.WriteLine("Catalan number {0} is 1", n);
        }
        else
        {
            for (int i = n + 2; i <= 2 * n; i++)
            {
                factorialExpression1 *= i;
            }
            for (int j = 1; j <= n; j++)
            {
                factorialExpression2 *= j;
            }
            catalanNum = factorialExpression1 / factorialExpression2;
            Console.WriteLine("Catalan number {0} is {1}", n, catalanNum);
        }        
    }
}
