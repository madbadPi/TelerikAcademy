using System;

class LetterstArrayFindIndex
{
    static void Main()
    {
        string word = Console.ReadLine();
        int maxLength = 52;
        char[] letterArray = new char[maxLength];
        for (int i = 0; i < maxLength; i++)
        {
            if (i <= 25)
            {
                letterArray[i] = (char)(65 + i);
            }
            else
            {
                letterArray[i] = (char)(71 + i);
            }
        }
        Console.WriteLine();
        for (int j = 0; j < word.Length; j++)
        {
            for (int k = 0; k < maxLength; k++)
            {
                if (word[j] == letterArray[k])
                {
                    Console.WriteLine(k);
                }
            }
        }
        Console.WriteLine();
    }
}
