using System;
using System.IO;
using System.Text;

class ReadAndInsertTextInFile
{
    static void Main()
    {
        string inptuFilePath = @"../../test.txt";
        StreamReader input = new StreamReader(inptuFilePath);
        StreamWriter output = new StreamWriter("../../result.txt");   
        using(input)
        using (output)
        {
            int counter = 1;
            for (string line; (line = input.ReadLine()) != null; counter++)
            {
                output.WriteLine("{0}. {1}", counter, line);
            }
        }
    }

}
