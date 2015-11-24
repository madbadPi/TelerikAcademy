using System;
using System.IO;

class ExtractFromXML
{
    static void Main()
    {
        using (StreamReader input = new StreamReader("../../input.txt"))
        {            
            for (int i = 0; (i= input.Read()) != -1 ; i++)
            {
                if (i == '>')
                {
                    string textWithoutTag = String.Empty;
                    while ((i = input.Read()) != -1 && i != '<')
                    {
                        textWithoutTag = textWithoutTag + Convert.ToChar(i);
                    }
                    Console.WriteLine(textWithoutTag.Trim());                    
                }
            }
        }
    }
}
