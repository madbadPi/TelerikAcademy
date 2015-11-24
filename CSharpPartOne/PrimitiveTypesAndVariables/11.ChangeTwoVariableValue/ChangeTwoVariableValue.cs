using System;

class ChangeTwoVariableValue
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("The original value : " + "a=" + a + " b=" + b);
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("The value after    : " + "a=" + a + " b=" + b);
    }
}

