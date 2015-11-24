using System;

class ExtractBitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Input number");
        int i = int.Parse(Console.ReadLine());
        Console.WriteLine("Input bit position");
        int b = int.Parse(Console.ReadLine());
        int mask = 1 << b;
        int bit = (mask & i) >> b;
        Console.WriteLine("{0} bit of number {1} (or {2} in binary code) is {3}", b, i, Convert.ToString(i, 2), bit);
    }
}
