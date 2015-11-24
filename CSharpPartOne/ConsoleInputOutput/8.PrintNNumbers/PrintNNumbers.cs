using System;

class PrintNNumbers
{
    static void Main()
    {
        Console.WriteLine("Write a number");
        int number = int.Parse(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine("{0}", i);
        }
    }
}
