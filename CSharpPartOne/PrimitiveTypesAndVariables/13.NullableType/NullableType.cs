using System;
    
class NullableType
{
    static void Main(string[] args)
    {
        int? x = null;
        double? y = null;
        Console.WriteLine("The value of x is {0}", x + "NULL");
        Console.WriteLine("The value of y is {0}", y + "NULL");
        int newX = x.GetValueOrDefault() + 1;
        double newY = y.GetValueOrDefault() + 0.5;
        Console.WriteLine("The new value of x is {0}", newX);
        Console.WriteLine("The new value of y is {0}", newY);
    }
}
