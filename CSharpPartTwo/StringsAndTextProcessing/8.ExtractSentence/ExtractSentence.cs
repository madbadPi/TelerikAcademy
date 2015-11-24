using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class ExtractSentence
{
    static void Main()
    {
        string inputText = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string word = "in";
        MatchCollection sentences = Regex.Matches(inputText, @"\s*([^\.]*\b" + word + @"\b.*?\.)");
        foreach (var sentence in sentences)
        {            
            Console.WriteLine(sentence.ToString().Trim());
        }
    }
}
