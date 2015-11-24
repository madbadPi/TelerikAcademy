using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class ReversWordOrder
{
    static void Main()
    {
        string sentence = "C# is not C++, not PHP and not Delphi!";
        string pattern = @"\s+|,\s*|\.\s*|!\s*";
        List<string> words = new List<string>();
        List<string> separators = new List<string>();

        foreach (string word in Regex.Split(sentence, pattern))	
        {
            if (!String.IsNullOrEmpty(word))
            {
                words.Add(word);
            }
        }

        foreach (Match separator in Regex.Matches(sentence, patern))
        {
            separators.Add(separator.Value);
        }

        for (int i = 0; i < separators.Count; i++)
        {
            Console.Write(words[words.Count - 1 - i] + separators[i]);
        }
        Console.WriteLine();
    }
}
