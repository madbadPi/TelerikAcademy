using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

class Encryption
{
    private static string Decode(string result, char[] cipher)
    {
        string decrypMessage = Encode(result, cipher);
        return decrypMessage;
    }
    private static string Encode(string input, char[] cipher)
    {
        StringBuilder ecryptMessages = new StringBuilder();
        int counter = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (counter < cipher.Length)
            {
                ecryptMessages.Append((char)(input[i] ^ cipher[counter]));
            }
            else
            {
                counter = 0;
                ecryptMessages.Append((char)(input[i] ^ cipher[counter]));
            }
            counter++;
        }
        return ecryptMessages.ToString();        
    }

    static void Main()
    {
        string input = "Abruptly the sun was blotted out and a sudden deluge descended from the heavens. It fell steadily in a silver sheet for five minutes, then as abruptly stopped. It was the first rain, marking the beginning of the rainy season.";
        char[] cipher = new char[] { '@', '&', '!', '1' };
        string result = String.Empty;
        result = Encode(input, cipher);
        Console.WriteLine(result);
        Console.WriteLine();
        Console.WriteLine(Decode(result, cipher));
    }
}
