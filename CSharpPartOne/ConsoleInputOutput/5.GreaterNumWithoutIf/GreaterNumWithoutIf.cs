using System;

class GreaterNumWithoutIf
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write two numbers :");
        decimal number1 = decimal.Parse(Console.ReadLine());
        decimal number2 = decimal.Parse(Console.ReadLine());
        decimal greaterNumber = Math.Max(number1,number2);
        Console.WriteLine("The larger number is : {0}", greaterNumber);
    }
}

