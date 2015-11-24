using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class FindSubstringInText
{
    static void Main()
    {
        string input = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days";
        string targer = "in";
        int counter = Regex.Matches(input, targer, RegexOptions.IgnoreCase).Count;
        Console.WriteLine(counter);
    }
}
