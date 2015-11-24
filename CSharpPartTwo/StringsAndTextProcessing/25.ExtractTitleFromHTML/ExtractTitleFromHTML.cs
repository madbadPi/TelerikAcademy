using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class ExtractTitleFromHTML
{
    static void Main()
    {
         StreamReader input = new StreamReader(@"../../input.html");
         using (input)
         {
             string line = String.Empty;
             while ((line = input.ReadLine()) != null)
             {                 
                 string tagPattern = @"(?<=^|>)[^><]+?(?=<|$)";
                 MatchCollection matches = Regex.Matches(line, tagPattern);
                 foreach (var item in matches)
                 {
                     Console.WriteLine(item);
                 }
             }             
         }
    }
}
