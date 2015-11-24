using System;
using System.Text;
using System.IO;
using System.Collections.Generic;

class ReadSortTextFile
{    
    private static void WriteOutptInFile(List<string> resultLines)
    {
        using (StreamWriter output = new StreamWriter("../../output.txt"))
        {
            foreach (string line in resultLines)
            {
                output.WriteLine(line);
            }

        }
    }

    private static List<string> Sort(List<string> lines)
    {
        lines.Sort();
        return lines;
    }

    private static List<string> ReadFromFile()
    {
        using (StreamReader input = new StreamReader("../../input.txt"))
        {
            List<string> lines = new List<string>();
            for (string line; (line = input.ReadLine()) != null;)
            {
                lines.Add(line);
            }
            return lines;
        }
    }

    static void Main()
    {
        List<string> lines = ReadFromFile();
        WriteOutptInFile(Sort(lines));
    }
}
