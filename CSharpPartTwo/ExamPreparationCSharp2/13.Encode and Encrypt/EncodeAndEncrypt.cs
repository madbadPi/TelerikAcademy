using System;
using System.Text;

class EncodeAndEncrypt
{
    static string Encrypt(string message, string cypher)
    {
        string result = String.Empty;

        if(message.Length > cypher.Length)
        {
            result = EncryptWhenMessageIsLonger(message, cypher);
        }

        else
        {
            result = EncryptWhenCypherIsLonger(message, cypher);
        }

        return result;

    }

    static string EncryptWhenCypherIsLonger(string message, string cypher)
    {
        StringBuilder result = new StringBuilder(message);

        int messageIndex = 0;
        for (int i = 0; i < cypher.Length; i++)
        {
            char messageSymbol = result[messageIndex];
            char cypherSymbol = cypher[i];
            char encryptedSymbol = EncryptSymbol(messageSymbol, cypherSymbol);

            result[messageIndex] = encryptedSymbol;

            messageIndex++;

            if (messageIndex == message.Length)
            {
                messageIndex = 0;
            }
        }

        return result.ToString();
    }

    static string EncryptWhenMessageIsLonger(string message, string cypher)
    {
        StringBuilder result = new StringBuilder();

        int cypherIndex = 0;
        for (int i = 0; i < message.Length; i++)
        {
            //cypherIndex = i % cypher.Length; moghe i taka
            char messageSymbol = message[i];
            char cypherSymbol = cypher[cypherIndex];
            char encryptedSymbol = EncryptSymbol(messageSymbol, cypherSymbol);
            result.Append(encryptedSymbol);

            cypherIndex++;
            if (cypherIndex == cypher.Length)
            {
                cypherIndex = 0;
            }
        }

        return result.ToString();
    }

    private static char EncryptSymbol(char messageSymbol, char cypherSymbol)
    {
        char result = new char();
        int messageSymbolCode = messageSymbol - 'A';
        int cypherSymbolCode = cypherSymbol - 'A';
        result = (char)((messageSymbolCode ^ cypherSymbolCode) + 'A');

        return result;
    }

    static string Encode(string text)
    {
        StringBuilder result = new StringBuilder();

        char previousSymbol = text[0];
        int counter = 1;
        for (int i = 1; i < text.Length; i++)
        {

            if (text[i] == previousSymbol)
            {
                counter++;
            }
            else
            {
                if (counter == 1)
                {
                    result.Append(previousSymbol);
                }
                else if (counter == 2)
                {
                    result.Append(new string(previousSymbol, 2));
                }
                else
                {
                    result.Append(counter + previousSymbol.ToString());
                }
                counter = 1;
                
            }
            previousSymbol = text[i];
        }

        if (counter == 1)
        {
            result.Append(previousSymbol);
        }
        else if (counter == 2)
        {
            result.Append(new string(previousSymbol, 2));
        }
        else
        {
            result.Append(counter + previousSymbol.ToString());
        }
        counter = 1;

        return result.ToString();
    }
    static void Main()
    {
        //string test = Encode("aaaabbbccccaa");
        //string testTwo = Encrypt("ABC", "PQRST");

        string message = Console.ReadLine();
        string cypher = Console.ReadLine();

        string finalResult = Encode(Encrypt(message, cypher) + cypher) + cypher.Length;
        Console.WriteLine(finalResult);
    }
}