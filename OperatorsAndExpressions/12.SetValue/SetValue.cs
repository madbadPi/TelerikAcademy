using System;

class SetValue
{
    static void Main()
    {
        Console.WriteLine("Input number");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Input bit position");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Input value '0' or '1'");
        int v = int.Parse(Console.ReadLine());
        int mask;
        int resultNumber;
        if (v == 1)
        {
            mask = 1 << p;
            resultNumber = n | mask;
            Console.WriteLine("The original number is : {0}", Convert.ToString(n, 2));
            Console.WriteLine("The result number is :   {0}", Convert.ToString(resultNumber, 2));
        }
        else
        {
            mask = ~(1 << p);
            resultNumber = n & mask;
            Console.WriteLine("The original number is : {0}", Convert.ToString(n, 2));
            Console.WriteLine("The result number is :   {0}", Convert.ToString(resultNumber, 2));
        }
    }
}
