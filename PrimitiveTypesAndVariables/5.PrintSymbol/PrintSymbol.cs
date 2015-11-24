using System;

class PrintSymbol
{
    static void Main()
    {
        char c;
        c = '\u0048';
        Console.WriteLine("The symbol that has Unicode 72 is:\n" + c);
        c = (char)72;
        Console.WriteLine("The symbol that has Unicode 72 is:\n" + c);
    }
}
