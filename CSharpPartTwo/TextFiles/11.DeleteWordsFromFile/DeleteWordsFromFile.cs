using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class DeleteWordsFromFile
{
    static void Main(string[] args)
    {
        using (StreamReader input = new StreamReader("../../input.txt"))
        using (StreamWriter output = new StreamWriter("../../output.txt"))
        {
            string line = String.Empty;
            while ((line = input.ReadLine()) != null)
            {   
                //string result = Regex.Replace(line, @"\btest\w*\b", String.Empty);
                string result = Regex.Replace(line, @"\b[a-z]\w+", String.Empty);
                //string result = Regex.Replace(line, @"\b[A-Z]\w+", String.Empty); ;
                //string result = Regex.Replace(line, @"\b[0-9]\w+", String.Empty);
                output.WriteLine(result);
            }
        }
    }
}
