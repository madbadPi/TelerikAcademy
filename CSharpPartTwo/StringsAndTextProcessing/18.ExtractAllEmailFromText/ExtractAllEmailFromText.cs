using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class ExtractAllEmailFromText
{
    static void Main(string[] args)
    {
        string inputText = "krasi@mail.bg Text gesha@some.net, gesha@@some.net;bob@mail.bg\n\nfn12345@fmi.uni-sofia.bg  pro@eu.int | , , ;;; gero@dir.bg georo.georgiev@fmi.uni-sofia.bg";
        string splitPatern = @"[;|,|\s|\|]+";
        string[] fragments = Regex.Split(inputText, splitPatern);
        string emailPatern = @"^([a-zA-Z0-9_\-][a-zA-Z0-9_\-\.]{0,49})*?@(([a-zA-Z0-9][a-zA-Z0-9\-]{0,49}\.)*?[a-zA-Z]{2,4})$";
        ;
        foreach (var fragment in fragments)
        {
            bool isMatch = Regex.IsMatch(fragment, emailPatern);
            if (isMatch)
            {
                Console.WriteLine(fragment);
            }
        }
        Console.WriteLine();
    }
}
