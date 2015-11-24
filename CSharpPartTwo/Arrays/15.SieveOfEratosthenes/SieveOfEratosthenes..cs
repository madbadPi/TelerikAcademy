using System;

class SieveOfEratosthenes
{
    static void Main()
    {
        int lastNum = 10000000;
        bool[] eratostheneArray = new bool[lastNum];
        for (int i = 2; i < lastNum; i++)
        {
            eratostheneArray[i] = true;
        }
        Console.WriteLine();
        for (int j = 2; j < lastNum; j++)
        {
            if (eratostheneArray[j])
            {
                for (int p = 2; p*j <= lastNum; p++)
                {
                    eratostheneArray[p * j] = false;
                }
            }
        }
        for (int k = 0; k < lastNum; k++)
        {
            if (eratostheneArray[k])
            {
                Console.WriteLine(k);
            }
        }
    }
}
