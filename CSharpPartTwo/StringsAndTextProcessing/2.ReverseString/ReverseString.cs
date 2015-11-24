using System;
using System.Collections.Generic;
using System.Text;

class ReverseString
{
    static void Main(string[] args)
    {
        char[] input = Console.ReadLine().ToCharArray();
        Array.Reverse(input);
        Console.WriteLine(input);
    }
}
