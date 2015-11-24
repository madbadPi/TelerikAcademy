using System;

class ConvertHexToDecimal
{
    private static int Convert16To10(string s)
    {
        int result = 0;        
        for (int i = 0; i < s.Length; i++)
        {
            if (s[s.Length - 1 - i] >= 'A')
            {
                result += (s[s.Length - 1 - i] - 'A'+ 10) * Convert.ToInt32(Math.Pow(16, i));
            }
            else
            {
                result += (s[s.Length - 1 - i] - '0') * Convert.ToInt32(Math.Pow(16, i));
            }            
        }
        return result;
    }

    static void Main()
    {
        string inputNum = Console.ReadLine();
        Console.WriteLine(Convert16To10(inputNum));
    }
}
