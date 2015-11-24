using System;

class ExchangeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter first number");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number");
        int secondNumber = int.Parse(Console.ReadLine());
        int biggerNumber;
        if (firstNumber > secondNumber)
        {
            biggerNumber = firstNumber;
            firstNumber = secondNumber;
            secondNumber = biggerNumber;
        }
        Console.WriteLine("The first number is : {0} and the second number is : {1}", firstNumber, secondNumber);
    }
}