using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class Dictionary
{
    static void Main()
    {
        string[] dictionary = {
            ".NET - platform for applications from Microsoft",
            "CLR - managed execution environment for .NET",
            "namespace - hierarchical - organization of classes",
        };
        string inputWord = Console.ReadLine();
        foreach (string item in dictionary)
        {
            string[] fragment = Regex.Split(item, " - ");
            if (fragment[0] == inputWord)
            {
                Console.WriteLine("{0} - {1}", fragment[0], fragment[1]);
            }
        }
    }
}
