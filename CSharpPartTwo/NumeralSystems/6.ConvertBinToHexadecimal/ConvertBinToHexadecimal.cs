using System;

class ConvertBinToHexadecimal
{
    private static string ConvertBinToHex(string s)
    {
        string result = String.Empty;
        int len = s.Length;
        string tempString = String.Empty;
        while (len % 4 != 0)
        {
            tempString = 0 + tempString;
            len++;
            if (len % 4 == 0)
            {
                break;
            }
        }

        s = tempString + s;
        string[,] refArray = {
                                 {"0000","0"},
                                 {"0001", "1"},
                                 {"0010", "2"},
                                 {"0011", "3"},
                                 {"0100", "4"},
                                 {"0101", "5"},
                                 {"0110", "6"},
                                 {"0111", "7"},
                                 {"1000", "8"},
                                 {"1001", "9"},
                                 {"1010", "A"},
                                 {"1011", "B"},
                                 {"1100", "C"},
                                 {"1101", "D"},
                                 {"1110", "E"},
                                 {"1111", "F"},
                             };
        
        for (int i = 0; i < s.Length - 3; i += 4)
        {            
            for (int j = 0; j < refArray.GetLength(0); j++)
            {
                if (s.Substring(i, 4) == refArray[j,0])
                {
                    result = result + refArray[j, 1];
                }
            }
        }
        return result;
    }

    static void Main(string[] args)
    {
        string inputNum = Console.ReadLine();
        Console.WriteLine(ConvertBinToHex(inputNum));
    }
}
