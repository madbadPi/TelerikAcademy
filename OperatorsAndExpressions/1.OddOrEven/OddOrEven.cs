using System;

class OddOrEven
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());     
        bool isEven = (number % 2) == 0;
        if (isEven)
        {
            Console.WriteLine("The number {0} is even - {1}", number, isEven);
        }
        else
        {
            Console.WriteLine("The number {0} is even - {1}", number, isEven);
        }
    }
}
