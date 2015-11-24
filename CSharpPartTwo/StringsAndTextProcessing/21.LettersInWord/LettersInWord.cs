using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class LettersInWord
{
    static void Main()
    {
        string word = "house";//Console.ReadLine();

        
        Dictionary<char, int> letters = new Dictionary<char, int>();
        
        for (int i = 0; i < word.Length; i++)
        {
            if (letters.ContainsKey(word[i]))
            {
                letters[word[i]]++;
            }
            else
            {
                letters.Add(word[i], 1);
            }
        }

        foreach (var letter in letters)
        {
            Console.WriteLine("Letter {0} - number - {1}", letter.Key, letter.Value);
        }
    }
}
