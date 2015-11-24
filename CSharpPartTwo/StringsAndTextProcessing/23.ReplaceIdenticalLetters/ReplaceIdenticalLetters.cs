using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class ReplaceIdenticalLetters
{
    static void Main(string[] args)
    {
        string inputText = "aaaaabbbbbcdddeeeedssaa ghts";
        string lettersPattern = @"[a-zA-Z]";
        string outputText = String.Empty;
        MatchCollection matches = Regex.Matches(inputText, lettersPattern);
        for (int i = 0; i < matches.Count-1; i++)
        {
            if (matches[i].Value != matches[i+1].Value)
            {
                outputText += matches[i].Value;
            }
        }

        if (matches[matches.Count-1].Value != matches[matches.Count-2].Value)
        {
            outputText += matches[matches.Count - 1].Value;
        }
        Console.WriteLine(outputText);
    }
}
