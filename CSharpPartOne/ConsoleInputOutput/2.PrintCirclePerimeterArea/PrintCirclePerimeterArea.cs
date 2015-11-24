using System;

class PrintCirclePerimeterArea
{
    static void Main(string[] args)
    { 
        Console.WriteLine("Write the radius of a circle:");
        double radius = double.Parse(Console.ReadLine());
        double perimeter = 2 * Math.PI * radius;
        double area = Math.PI * radius * radius;
        Console.WriteLine("The perimeter of the circle with radius r={0} is {1:F2}", radius, perimeter);
        Console.WriteLine("The area of the circle with radius r={0} is {1:F2}", radius, area);
    }
}
