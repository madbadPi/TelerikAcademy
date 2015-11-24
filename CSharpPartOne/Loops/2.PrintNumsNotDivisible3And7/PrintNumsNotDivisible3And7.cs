using System;

class PrintNumsNotDivisible3And7
{
    static void Main()
    {
        int n;
        string consoleInput;
        do
        {
            Console.Write("Enter valid number n=");
            consoleInput = Console.ReadLine();
        }
        while (!int.TryParse(consoleInput, out n) || n < 1);
        bool numsExistFlag = false;
        for (int i = 1; i <= n; i++)
        {
            if ((i % 3 == 0) && (i % 7 == 0))
            {
                Console.WriteLine("Number :{0}", i);
                numsExistFlag = true;
            }
        }
        if (!numsExistFlag)
        {
            Console.WriteLine("No numbers eligible");
        }
    }
}