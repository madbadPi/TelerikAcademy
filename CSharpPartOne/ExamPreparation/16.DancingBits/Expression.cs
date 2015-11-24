using System;
using System.Globalization;
using System.Threading;

class DancingBits
{
    static void Main()
    {
       // Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double n = double.Parse(Console.ReadLine());
        double m = double.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());
        
        int angle = (int)(m % 180);
        double sinAngle = Math.Sin(angle);
        
        double mP = m * p;
        double numP = 128.523123123d * p;
        double expression = 0;
        
        expression = (((n*n) + (1 / mP) + 1337))/(n - numP) + sinAngle;
        Console.WriteLine("{0:F6}", expression);
       
    }
}
