using System;
    
class EscQuotedString
{
    static void Main(string[] args)
    {
        string quotedString = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(quotedString);
        string unquotedString = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine(unquotedString);
    }
}
