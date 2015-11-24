using System;

class ConvertBaseToBase
{
    private static string ConvertBaseSToBaseD(string numString, int s, int d)
    {
        string result = String.Empty;
        result = ConvertBase10ToBaseD(ConvertBaseSToBase10(numString, s), d);
        return result;
    }

    private static string ConvertBase10ToBaseD(int num, int d)
    {
        string result = String.Empty;      
        while (num > 0)
        {
            if (num % d > 9)
            {
                result = (char)(num % d + 'A' - 10) + result;
            }
            else
            {
                result = num % d + result;
            }
            num = num / d;
        }
        return result;
    }

    private static int ConvertBaseSToBase10(string numString, int s)
    {
        int result = 0;
        for (int i = 0; i < numString.Length; i++)
        {
            if (numString[numString.Length - 1 - i] >= 'A')
            {
                result += (numString[numString.Length - 1 - i] - 'A' + 10) * Convert.ToInt32(Math.Pow(s, i));
            }
            else
            {
                result += (numString[numString.Length - 1 - i] - '0') * Convert.ToInt32(Math.Pow(s, i));
            } 
        }
        return result;
    }

    static void Main()
    {
        int baseS = 13;//int.Parse(Console.ReadLine());
        int baseD = 7;//int.Parse(Console.ReadLine());
        string inputNum = "AB195"; //Console.ReadLine();
        Console.WriteLine(ConvertBaseSToBaseD(inputNum, baseS, baseD));
    }
}
