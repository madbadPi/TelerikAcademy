using System;

class SumOfNumbers
{
    static void Main()
    {
        Console.WriteLine("How many number are we going to sum ?");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Write number{0}", i);
            int currentNumber = int.Parse(Console.ReadLine());
            sum = sum + currentNumber;
        }
        Console.WriteLine("Sum={0}", sum);
    }
}
