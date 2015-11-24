using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class ParseURL
{
    static void Main()
    {
        string inputURL = "http://www.devbg.org/forum/index.php ";        
        string patternt = @"(.*)://(.*?)(/.*)";
        var matches = Regex.Match(inputURL, patternt).Groups;
        for (int i = 1; i < matches.Count; i++)
        {
            Console.WriteLine(matches[i]);
        }
        Console.WriteLine();
    }
}
