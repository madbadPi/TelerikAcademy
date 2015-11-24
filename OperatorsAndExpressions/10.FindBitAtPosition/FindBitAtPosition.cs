using System;

class FindBitAtPosition
{
    static void Main()
    {
        Console.WriteLine("Input number");
        int v = int.Parse(Console.ReadLine());
        Console.WriteLine("Input bit position");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int bit = (mask & v) >> 3;
        if (bit == 1)
        {
            Console.WriteLine("Bit at position {0} of number {1} (or {2} in a binary code) is '1' - true", p, v, Convert.ToString(v, 2));
        }
        else
        {
            Console.WriteLine("Bit at position {0} of number {1} (or {2} in a binary code) is '1' - false", p, v, Convert.ToString(v, 2));
        }
    }
}