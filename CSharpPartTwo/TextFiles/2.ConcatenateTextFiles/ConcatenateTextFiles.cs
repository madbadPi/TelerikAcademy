using System;
using System.IO;

class ConcatenateTextFiles
{
    static void Main()
    {
        string firstFilePath = @"../../First.txt";
        string secondFilePath = @"../../Second.txt";
        string resultPath = @"../../result.txt";
        StreamReader firstPart = new StreamReader(firstFilePath);
        StreamReader secondPart = new StreamReader(secondFilePath);
        StreamWriter result = new StreamWriter(resultPath);
        string lineOne = String.Empty;
        string lineTwo = String.Empty;
        string resultStr = String.Empty;
        using(firstPart)
	    {
            lineOne = firstPart.ReadToEnd();
        }
        using (secondPart)
        {
            lineTwo = secondPart.ReadToEnd();
        }
        using (result)
        {
            resultStr = lineOne + "\r\n" + lineTwo;
            result.WriteLine(resultStr);            
        }
    }
}
