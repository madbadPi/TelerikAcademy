using System;
using System.Text;
using System.Text.RegularExpressions;

    class ChangeTextInTags
    {
        static void Main()
        {
            string input = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            string target = @"<upcase>(?<capLetters>.*?)</upcase>";            
            Console.WriteLine(Regex.Replace(input, target, match => match.Groups["capLetters"].Value.ToUpper()));            
        }
    }

