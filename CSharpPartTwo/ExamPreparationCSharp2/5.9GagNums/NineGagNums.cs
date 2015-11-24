using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class NineGagNum
{
    static string ConvertGagStringToNum(string digit)
    {
        string result = "No";
        switch (digit)
        {
            case "-!": result = "0"; break;
            case "**": result = "1"; break;
            case "!!!": result = "2"; break;
            case "&&": result = "3"; break;
            case "&-": result = "4"; break;
            case "!-": result = "5"; break;
            case "*!!!": result = "6"; break;
            case "&*!": result = "7"; break;
            case "!!**!-": result = "8"; break;
            default:
                break;
        }
        return result;
    }

    static BigInteger PowOfNine(int power)
    {
        BigInteger result = 1;
        for (int i = 0; i < power; i++)
        {
            result *= 9;
        }
        return result;
    }

    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string partialInput = String.Empty;
        string nineSystemNum = String.Empty;

        for (int i = 0; i < input.Length; i++)
        {
            partialInput += input[i];
            string currentDigit = ConvertGagStringToNum(partialInput);
            if (currentDigit != "No")
            {
                nineSystemNum += currentDigit;
                partialInput = String.Empty;
            }
        }

        BigInteger result = 0;
        for (int i = 0; i < nineSystemNum.Length; i++)
        {
            BigInteger digit = BigInteger.Parse(nineSystemNum[i].ToString());
            result += digit * (BigInteger)PowOfNine(nineSystemNum.Length - 1 - i);            
        }
        Console.WriteLine(result);
    }
}
