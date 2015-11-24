using System;
using System.Text;


class ReadStringWithMaxLen
{
    static void Main(string[] args)
    {
        string input = "123456789 123456789 123456789";//Console.ReadLine();
        int len = input.Length;
        string newString = String.Empty;
        if (len >= 20)
        {
            newString = input.Remove(20, len - 20);
        }
        else
        {
            newString = input.PadRight(20, '*');
        }
        Console.WriteLine(newString);   
    }
}
