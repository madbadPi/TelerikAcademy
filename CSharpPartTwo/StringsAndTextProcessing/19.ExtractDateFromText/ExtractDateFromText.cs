using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

class ExtractDateFromText
{
    static void Main(string[] args)
    {
        string inputText = "John Vincent Atanasoff (04.10.1903 – 48.07.1995)"+
        "was an American physicist and inventor, best known for inventing the first electronic digital computer."+
        "Atanasoff, of Bulgarian, French and Irish ancestry, was born on 04/01/1903 (4.10.1903)";

        string datePattern = @"[0-9]{2}[.]{1}[0-9]{2}[.]{1}[0-9]{4}";
        MatchCollection matches = Regex.Matches(inputText, datePattern);
        DateTime result = new DateTime();
        foreach (var match in matches)
        {
            if (DateTime.TryParse(match.ToString(), out result))
            {
                Console.WriteLine(result.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
            }
        }
    }
}

