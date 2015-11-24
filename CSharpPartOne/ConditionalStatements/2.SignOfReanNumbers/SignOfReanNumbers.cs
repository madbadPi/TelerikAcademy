using System;

class SignOfReanNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter first real number:");
        float number1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter second real number:");
        float number2 = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter third real number:");
        float number3 = float.Parse(Console.ReadLine());
        int x = 0;
        string sign;
        if ((number1 == 0) || (number2 == 0) || (number3 == 0))
        {
            Console.WriteLine("The product is 0");
        }
        else
        {
            if (number1 < 0)
            {
                x++;
            }
            if (number2 < 0)
            {
                x++;
            }
            if (number3 < 0)
            {
                x++;
            }

            if (x % 2 == 0)
            {
                sign = "positive";
            }
            else
            {
                sign = "negative";
            }
            Console.WriteLine("The product is with {0} sign", sign);
        }
    }
}
