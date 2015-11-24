using System;
using System.Text;
using System.Text.RegularExpressions;

class ReplaceForbiddenWords
{
    static void Main(string[] args)
    {
        string inputText = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string words = "PHP,CLR,Microsoft";
        string[] wordsList = words.Split(',', ' ');

        for (int i = 0; i < wordsList.Length; i++)
        {
            inputText = Regex.Replace(inputText, @"\b" + wordsList[i] + @"\b", m => new String('*', m.Length));
        }
        Console.WriteLine(inputText);
    }
}
