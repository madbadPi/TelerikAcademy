using System;
//using System.Text;

class PrintASCIItable
{
    static void Main()
    {
        Console.WriteLine("ASCII tabel:");
        for (int i = 0; i <= 127; i++)
        {
            char c = (char)i;
            Console.WriteLine("{0} {1} ", i, c);
        }
    }
}
