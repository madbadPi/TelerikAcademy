using System;

class ConvertDecimalToHexadecimal
{
    private static string ConvertDecimalToBinary(string result, int inputNum)
    {
        while (inputNum > 0)
        {
            if (inputNum % 16 > 9)
            {
                result = (char)(inputNum % 16 + 55) + result;
            }
            else
            {
                result = inputNum % 16 + result;
            }
            inputNum = inputNum / 16;
        }
        return result;
    }

    static void Main()
    {
        int inputNum = int.Parse(Console.ReadLine());
        string result = String.Empty;
        Console.WriteLine(ConvertDecimalToBinary(result, inputNum));

    }
}
