using System;

class FindThirdBit
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("The number {0} is {1} in binary code", number, Convert.ToString(number, 2));
        int mask = 1 << 3;
        int bit = (mask & number) >> 3;
        Console.WriteLine("The third bit of {0} is {1}", number, bit);
    }
}

