using System;
using System.IO;
using System.Text.RegularExpressions;

class FindAndReplaceWordInFile
{
    static void Main()
    {
        using (StreamReader input = new StreamReader("../../input.txt"))
        using (StreamWriter output = new StreamWriter("../../output.txt"))
        {
            string line = String.Empty;
            while ((line = input.ReadLine()) != null)
            {
                string result = Regex.Replace(line, @"\bstart\b", "finish");
                output.WriteLine(result);
            }
        }
    }
}
