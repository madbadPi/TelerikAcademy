using System;

class ConvertBinToDecimal
{    
    private static void Print(int result)
    {
        Console.WriteLine(result);
    }

    private static void ConvertBinaryToDecimal(string s, ref int result)
    {                
        for (int i = 0; i < s.Length; i++)
        {
            result += (s[s.Length - 1 - i] - '0') * Convert.ToInt32(Math.Pow(2, i));            
        }
    }

    static void Main()
    {
        string inputNum = Console.ReadLine();
        int result = 0;
        ConvertBinaryToDecimal(inputNum, ref result);
        Print(result);
    }

}
