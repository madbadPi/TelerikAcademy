using System;

class ConvertHexToBin
{
    private static string ConvertHexToBinary(string s)
    {
        int tempResult = 0;
        string result = String.Empty; 
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] >= 'A')
            {
                tempResult = s[i] - 'A' + 10;
            }
            else
            {
                tempResult = s[i] - '0';
            }
            for (int j = 0; j < 4; j++)
            {
                result = tempResult % 2 + result;
                tempResult = tempResult / 2;
            }
        }
        return result;
    }

    static void Main()
    {
        string inputNum = Console.ReadLine();
        Console.WriteLine(ConvertHexToBinary(inputNum));
    }
}
