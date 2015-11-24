using System;

class ReadAndCalcSumFromString
{
    private static int CalcSumFromString(string s)
    {
        int power = 0;
        int sum = new int();
        for (int i = s.Length; i >= 0; i--)
        {
            if (i == s.Length || s[i] == ' ')
            {
                power = 0;
            }
            else
            {
                sum += (s[i] - '0') * (int)(Math.Pow(10, power));
                power++;
            }            
        }
        return sum;
    }

    static void Main()
    {
        string inputString = "43 68 9 23 318";
        Console.WriteLine(CalcSumFromString(inputString));
    }
}
