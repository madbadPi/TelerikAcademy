using System;

class BinaryRepresentationShort
{
    private static string RepresenAsBinary(short num)
    {
        string result = String.Empty;
        for (int i = 0; i < 16; i++)
        {
            result = ((num >> i) & 1) + result;            
        }
        return result;
    }

    static void Main()
    {
        short inputNum = 32766;//short.Parse(Console.ReadLine());
        Console.WriteLine(RepresenAsBinary(inputNum));
    }
}
