namespace StringMaxLen
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StrMaxLangth
    {
        static void Main()
        {
            List<string> strArray = new List<string>
            {
                "qazwsx",
                "qwertyuyy",
                "qazwsxedcrfv",
                "qazwsxrfvtbb",
                "q",
                "c"
            };
            int maxLen = 0;
            foreach (var str in strArray)
            {
                if (str.Length > maxLen)
                {
                    maxLen = str.Length;
                }
            }

            var strWithMaxLen = strArray
                .Where(s => s.Length == maxLen);

            foreach (var item in strWithMaxLen)
            {
                Console.WriteLine(item);
            }
        }
    }
}
