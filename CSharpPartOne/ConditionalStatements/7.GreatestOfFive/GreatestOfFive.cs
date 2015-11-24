using System;

class GreatestOfFive
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        int number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int number2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number:");
        int number3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter fourth number");
        int number4 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter fifth number");
        int number5 = int.Parse(Console.ReadLine());
        int maxNumber1 = Math.Max(number1, number2);
        int maxNumber2 = Math.Max(number2, number3);
        maxNumber1 = Math.Max(maxNumber1, number4);
        maxNumber2 = Math.Max(maxNumber2, number5);
        if (maxNumber1 < maxNumber2)
        {
            Console.WriteLine("The greatest number is : {0}", maxNumber2);
        }
        else
        {
            Console.WriteLine("The greatest number is : {0}", maxNumber1);
        }
    }
}
