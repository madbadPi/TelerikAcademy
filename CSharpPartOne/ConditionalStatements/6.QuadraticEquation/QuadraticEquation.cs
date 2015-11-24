using System;

class QuadraticEquation
{
    static void Main(string[] args)
    {
        Console.Write("Write the coefficient of quadratic equation a=");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Write the coefficient of quadratic equation b=");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Write the coefficient of quadratic equation c=");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("The equation is:\n{0}*x*x + ({1})*x + ({2}) = 0", a, b, c);
        double discriminant = b * b - 4 * a * c;
        Console.WriteLine("D={0}", discriminant);
        if (discriminant >= 0)
        {
            double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            if (discriminant == 0)
            {
                Console.WriteLine("x1=x2={0}", x1);
            }
            else
            {
                Console.WriteLine("x1={0}, x2={1}", x1, x2);
            }
        }
        else
        {
            Console.WriteLine("There are no real roots of the equation");
        }
    }
}
