using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class ExtractPalindromes
{
    static void Main(string[] args)
    {
        string inputText = " TABBA lamal exe exes lambda, dead! 12321 ABBA?";
        string wordPattern = @"\w+";
        MatchCollection matches = Regex.Matches(inputText, wordPattern);
        foreach (Match match in matches)
        {
            string currentWord = match.Value;
            if(isPalindrome(currentWord))
            {
                Console.WriteLine(match);
            }
        }
        Console.WriteLine();
    }

    private static bool isPalindrome(string currentWord)
    {
        for (int i = 0; i < currentWord.Length/2; i++)
        {
            if (currentWord[i] != currentWord[currentWord.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
}
