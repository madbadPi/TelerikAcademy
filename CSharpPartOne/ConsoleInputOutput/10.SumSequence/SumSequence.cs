using System;

class SumSequence
{
    static void Main()
    {
        double prevSum = 1.0;
        double sum = 1.5;
        int sign = -1;
        int i = 3;
        while (Math.Abs(sum-prevSum) >= 0.001)
        {
            prevSum = sum;
            sum = sum + (sign*1.0)/i;
            sign = sign * (-1);
            i++;
        }
        Console.WriteLine(i + "The sum of the sequence sum={0:F3}", sum);
    }
}
