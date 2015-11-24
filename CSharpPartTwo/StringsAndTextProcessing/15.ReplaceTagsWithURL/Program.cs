using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            string inputText = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
            string pattern = "<a href=\"(.*?)\">(.*?)</a>";            
            var outputTex = Regex.Replace(inputText, pattern, "[URL= $1]$2[/URL]");
            Console.WriteLine(outputTex);
        }
    }