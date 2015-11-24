using System;

class Sevenland
{
    static void Main()
    {
        int inputNumberK = int.Parse(Console.ReadLine());
        int nextNumberK = inputNumberK;        
        int n = 0;
        int firstNumK = inputNumberK / 100;
        int secondNumK = inputNumberK / 10 - (inputNumberK / 100) * 10;
        int lastNumK = inputNumberK % 10;
        while (inputNumberK / 10 != 0)
        {
            inputNumberK /=10;
            n++;
        }
        //Console.WriteLine(n);

        if (n == 0)
        {   
            if (0 <= inputNumberK && inputNumberK < 6)
            {
                nextNumberK++;
            }
            else
            {
                nextNumberK += 4;
            }
            Console.WriteLine(nextNumberK);
        }
        if (n == 1)
        {
            if (lastNumK >= 6)
            {
                secondNumK++;
                lastNumK = 0;
            }
            else if (lastNumK < 6)
            {
                lastNumK++;
            }
            Console.Write("{0}{1}", secondNumK, lastNumK);

        }
        if (n == 2)
        {
            if (lastNumK  >= 6)
            {
                if (secondNumK +1 >= 6)
                {
                    if (firstNumK + 1 >= 6)
                    {
                        firstNumK = 0;
                        secondNumK = 0;
                        lastNumK = 0;
                        Console.Write("1");
                    }
                    else
                    {
                        firstNumK++;
                        secondNumK = 0;
                        lastNumK = 0;
                    }
                }
                else if (secondNumK + 1 < 6)
                {
                    secondNumK++;
                    lastNumK = 0;
                }
            }
            else if (lastNumK < 6)
            {
                lastNumK++;
            }
            Console.Write("{0}{1}{2}", firstNumK, secondNumK, lastNumK);
        }
    }
}
