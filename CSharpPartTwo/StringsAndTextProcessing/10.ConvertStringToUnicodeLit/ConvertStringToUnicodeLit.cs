using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ConvertStringToUnicodeLit
{
    static void Main(string[] args)
    {
        string input = "Hi!";
        string output = String.Empty;
        for (int i = 0; i < input.Length; i++)
        {
            output = String.Format("\\u{0:X4}", (int)input[i]);
            Console.Write(output);
        }
    }
}
