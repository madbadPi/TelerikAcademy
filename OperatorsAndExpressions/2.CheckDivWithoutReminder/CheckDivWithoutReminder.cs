using System;

class CheckDivWithoutReminder
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());     
        bool isTrue = (number % 7) == 0 && (number % 5) == 0;
        Console.WriteLine("The number {0} can be divided by 7 and 5 at the same time - {1}", number, isTrue);
    }
}

