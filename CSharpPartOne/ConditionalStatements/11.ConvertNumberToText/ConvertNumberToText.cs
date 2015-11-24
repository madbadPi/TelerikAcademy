using System;

class ConvertNumberToText
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number in the range [0,999]");
        int number = int.Parse(Console.ReadLine());
        string[] zeroToNineteen = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine",
                                             "ten", "eleven", "tweleve", "thirteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        string[] twentyToNinety= new string[] { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        if ((number >= 0) && (number <= 999))
        {
            int digit1 = number / 100;
            int digit2 = number / 10 - digit1 * 10;
            int digit3 = number - (number / 10) * 10;
            int digit2digit3 = (number - (number / 100) * 100);
            if (digit1 != 0)
            {
                if (digit2digit3 >= 20)
                {
                    if (digit3 != 0)
                    {
                        Console.WriteLine(zeroToNineteen[digit1] + " hundred " + twentyToNinety[digit2 - 2] + " " + zeroToNineteen[digit3]);
                    }
                    else
                    {
                        Console.WriteLine(zeroToNineteen[digit1] + " hundred " + twentyToNinety[digit2 - 2]);
                    }
                }
                else
                {
                    if (digit2digit3 != 0)
                    {
                        Console.WriteLine(zeroToNineteen[digit1] + " hundred " + zeroToNineteen[digit2digit3]);
                    }
                    else
                    {
                        Console.WriteLine(zeroToNineteen[digit1] + " hundred ");                        
                    }
                }
            }
            else if (digit2digit3 >= 20)
                 {
                    if (digit3 != 0)
                    {
                        Console.WriteLine(twentyToNinety[digit2 - 2] + " " + zeroToNineteen[digit3]);
                    }
                    else
                    {
                        Console.WriteLine(twentyToNinety[digit2 - 2]);
                    }
                 }
                 else
                 {
                     Console.WriteLine(zeroToNineteen[digit2digit3]);
                 }
        }
    }
}
