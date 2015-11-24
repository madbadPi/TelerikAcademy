using System;
using System.Collections.Generic;
using System.Text;

class CheckBrackets
{
    private static bool isBracketsCorrectly(string input)
    {
        int counter = 0;
        bool isBracketsPutCorrectly = false;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(')
            {
                counter++;
            }
            if (input[i] == ')')
            {
                counter--;
            }
        }
        if (counter == 0)
        {
            isBracketsPutCorrectly = true;
        }
        return isBracketsPutCorrectly;
    }

    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        Console.WriteLine("The brackets are put correctly - {0}", isBracketsCorrectly(input));
    }    
}
