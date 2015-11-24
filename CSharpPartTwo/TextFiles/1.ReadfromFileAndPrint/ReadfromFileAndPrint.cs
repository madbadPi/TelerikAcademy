using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class ReadfromFileAndPrint
{
    static void Main()
    {
        string filePath = @"../../ReadfromFileAndPrint.cs";
        StreamReader input = new StreamReader(filePath);
        using (input)
        {            
            int counter = 1;
            string line = String.Empty;
            do
            {
                line = input.ReadLine();
                if (counter % 2 != 0)
                {
                    Console.WriteLine(line);
                }
                counter++;
            } while (line != null);           
        }   
    }
}