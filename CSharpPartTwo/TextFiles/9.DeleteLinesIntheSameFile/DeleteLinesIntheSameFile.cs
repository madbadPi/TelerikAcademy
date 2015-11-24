using System;
using System.Collections.Generic;
using System.IO;

class DeleteLinesIntheSameFile
{
    static void Main()
    {
        WriteInSameFile(RemoveLines(ReadFromFile()));        
    }

    private static void WriteInSameFile(List<string> text)
    {
        using (StreamWriter output = new StreamWriter("../../Output.txt"))
        {
            foreach (var line in text)
            {
                output.WriteLine(line);
            }
            
        }
    }
    private static List<string> RemoveLines(List<string> text)
    {
        List<string> resultText = new List<string>();
        for (int i = 0; i < text.Count; i++)
        {
            if (i % 2 == 0)
            {
                resultText.Add(text[i]);
            }
        }
        return resultText;
    }

    private static List<string> ReadFromFile()
    {
        string line = String.Empty;
        List<string> text = new List<string>();
        using (StreamReader input = new StreamReader("../../Input.txt"))
        {
            while ((line = input.ReadLine()) != null)
            {
                text.Add(line);
            }
        }
        return text;
    }
}
