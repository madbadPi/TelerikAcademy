using System;

class ConcatenationAndTypeCasting
{
    static void Main(string[] args)
    {
        string hello = "Hello";
        string world = "World";
        object c = hello + ' ' + world;
        string sentece = (string)c;
        Console.WriteLine(sentece);
    }
}
