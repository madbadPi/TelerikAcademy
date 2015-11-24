using System;

class ReplacingBits
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        int positionFirst = 3;
        int positionSecond = 24;
        int mask1 = 7 << positionFirst;
        int mask2 = 7 << positionSecond;
        int getNumbers1 = number & mask1;
        int getNumbers2 = number & mask2;
        int change = (number & ~mask1) & ~mask2;
        int mask3 = (getNumbers1 >> positionFirst) << positionSecond;
        int mask4 = (getNumbers2 >> positionSecond) << positionFirst;
        int resultNumber = (change | mask3) | mask4;
        Console.WriteLine("The original number is : {0}", Convert.ToString(number, 2));
        Console.WriteLine("The result number is :   {0}", Convert.ToString(resultNumber, 2));
    }
}
