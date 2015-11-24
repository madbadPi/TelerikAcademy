using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class SortListOfWordsAlphabetically
{
    static void Main()
    {
        string inputText = "Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order";
        List<string> words = new List<String>();
        MatchCollection matches = Regex.Matches(inputText, @"\w+");
        for (int i = 0; i < matches.Count; i++)
        {
            words.Add(matches[i].Value);
        }

        words.Sort();

        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
    }
}
