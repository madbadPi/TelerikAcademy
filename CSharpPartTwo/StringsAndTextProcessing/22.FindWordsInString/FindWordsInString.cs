using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class FindWordsInString
{
    static void Main()
    {
        string inputText = "Write write write a program that reads reads reads a string from the console and lists all different words in the string along with information how many times each word is found";
        Dictionary<string, int> words = new Dictionary<string, int>();
        string wordPattern = @"\w+";
        MatchCollection matches = Regex.Matches(inputText, wordPattern, RegexOptions.IgnoreCase);
        for (int i = 0; i < matches.Count; i++)
        {
            if (words.ContainsKey(matches[i].Value))
            {
                words[matches[i].Value]++;
            }
            else
            {
                words.Add(matches[i].Value, 1);
            }
        }

        foreach (var word in words)
        {
            Console.WriteLine("word {0} - found - {1}", word.Key, word.Value);
        }
    }
}
