using System;

class PrimeNumber
{
    static void Main()
    {
        Console.WriteLine("Enter number");
        int number = int.Parse(Console.ReadLine());
        if (2 == number || 3 == number || 5 == number || 7 == number)
        {
            Console.WriteLine("The number is prime");
        }
        else
        {
            if (((number % 2) != 0) && ((number % 3) != 0) && ((number % 5) != 0) && ((number % 7) != 0))
            {
                Console.WriteLine("The number is prime");
            }
            else
            {
                Console.WriteLine("The number is not prime");
            }
        }
    }
}

