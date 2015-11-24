using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.WriteLine("Input sides a and b and height h of trapezoid");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        Console.WriteLine("The area of trapeziod is {0}", (a + b) * h / 2);
    }
}
