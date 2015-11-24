using System;

class PrintName
{
    private static void PrintUsersName(string inputName)
    {
        Console.WriteLine("Hello, {0}!", inputName);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Type your name");
        string name = Console.ReadLine();
        PrintUsersName(name);
    }    
}
