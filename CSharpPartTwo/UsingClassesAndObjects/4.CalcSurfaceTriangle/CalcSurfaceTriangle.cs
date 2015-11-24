using System;

class CalcSurfaceTriangle
{    
    private static double GetAreaWithTwoSidesAndAngle(int a, int b, int c)
    {
        return (a * b * Math.Sin(c * Math.PI / 180)) / 2;
    }

    private static double GetAreaWithThreeSides(int a, int b, int c)
    {
        int semiPerim = (a + b + c) / 2;
        return Math.Sqrt(semiPerim * (semiPerim - a) * (semiPerim - b) * (semiPerim - c));
    }

    private static double GetAreaWithAlthitude(int a, int h)
    {
        return (a * h) / 2;
    }

    static void Main()
    {
        int altitude = int.Parse(Console.ReadLine());
        int sideA = 10;
        int sideB = 6;
        int sideC = 7;
        int angel = 90;
        Console.WriteLine(GetAreaWithAlthitude(sideA, altitude));
        Console.WriteLine(GetAreaWithThreeSides(sideA, sideB, sideC));
        Console.WriteLine(GetAreaWithTwoSidesAndAngle(sideA, sideB, angel));
    }
}
