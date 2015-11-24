using System;

class BiggestOfThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number:");
        int c = int.Parse(Console.ReadLine());
        int biggestNuber = -111111;
        if ((a >= b) && (a >= c))
        {
            biggestNuber = a;
        }
        else if ((b >= a) && (b >= c))
        {
            biggestNuber = b;
        }
        else         
        {
            biggestNuber = c;
        }
        Console.WriteLine("The biggest number is : {0}", biggestNuber);
    }
}
