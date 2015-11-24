using System;

class MinAndMaxNumsFromSequence
{
    static void Main()
    {
        int n;
        int minNumber;
        int maxNumber;
        int number;
        Console.Write("Enter n=");
        n = int.Parse(Console.ReadLine());
        Console.Write("Enter number 1:");
        number = int.Parse(Console.ReadLine());
        minNumber = maxNumber = number;
        for (int i = 2; i <= n; i++)
        {
            Console.Write("Enter number {0}:", i);
            number = int.Parse(Console.ReadLine());
            minNumber = Math.Min(number, minNumber);
            maxNumber = Math.Max(number, maxNumber);
        }
        Console.WriteLine("The minimal number of the sequence is {0} and the maximum is {1}", minNumber, maxNumber);
    }
}
