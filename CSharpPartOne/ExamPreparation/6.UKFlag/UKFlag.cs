using System;

class UKFlag
{
    static void Main()
    {
        int lines = int.Parse(Console.ReadLine());
        int innerDot = lines / 2 -1;
        int outerDot = 0;
        for (int i = 0; i < lines / 2; i++)
        {
            Console.Write(new string ('.', outerDot));
            Console.Write('\\');
            Console.Write(new string('.', innerDot));
            Console.Write('|');
            Console.Write(new string('.', innerDot));
            Console.Write('/');
            Console.Write(new string ('.', outerDot));
            outerDot++;
            innerDot--;
            Console.WriteLine();
        }
        Console.Write(new string('-', lines/2));
        Console.Write(new string('*', 1));
        Console.WriteLine(new string('-', lines/2));
        outerDot = lines / 2 -1;
        innerDot = 0;
        for (int i = 0; i < lines / 2; i++)
        {
            Console.Write(new string('.', outerDot));
            Console.Write('/');
            Console.Write(new string('.', innerDot));
            Console.Write('|');
            Console.Write(new string('.', innerDot));
            Console.Write('\\');
            Console.Write(new string('.', outerDot));
            outerDot--;
            innerDot++;
            Console.WriteLine();
        }
    }
}

