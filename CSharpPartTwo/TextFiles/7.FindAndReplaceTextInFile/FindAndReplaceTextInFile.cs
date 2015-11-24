using System;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

class FindAndReplaceTextInFile
{
    static void Main()
    {
        using(StreamReader input = new StreamReader("../../input.txt"))
        using (StreamWriter output = new StreamWriter("../../output.txt"))
        {
            string line = String.Empty;
            while ((line = input.ReadLine()) != null )
	        {
                string result = Regex.Replace(line, "start", "finish");
                output.WriteLine(result);
	        }
        }
    }
}
