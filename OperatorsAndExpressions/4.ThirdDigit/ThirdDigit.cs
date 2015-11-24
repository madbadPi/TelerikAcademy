using System;

class ThirdDigit
{
    static void Main()
    {
        Console.WriteLine("Enter number");
        int number = int.Parse(Console.ReadLine());
        bool isThirdDig7 = (number / 100 % 10) == 7;
        Console.WriteLine("The third digit is 7 - {0}", isThirdDig7);
    }
}