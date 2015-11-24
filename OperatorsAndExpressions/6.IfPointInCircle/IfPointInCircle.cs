using System;

class IfPointInCircle
{
    static void Main()
    {
        Console.WriteLine("Enter point coordinates P(x,y)");
        int pointX = int.Parse(Console.ReadLine());
        int pointY = int.Parse(Console.ReadLine());
        int radius = 5;
        Console.WriteLine("The Point({0},{1}) is within a circle(0,{2}) - {3}", pointX, pointY, radius, (pointX * pointX) + (pointY * pointY) <= (radius * radius));
    }
}
