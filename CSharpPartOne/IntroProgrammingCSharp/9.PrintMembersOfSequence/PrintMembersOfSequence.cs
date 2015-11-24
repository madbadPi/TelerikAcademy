using System;

class PrintMembersOfSequence
{
    static void Main()
    {
        int numberRem;
        int number = 2;
        for (int i = 0; i <= 9; i++)
        {
            Math.DivRem(number, 2, out numberRem);
            if (numberRem == 0)
            {
                Console.WriteLine(Math.Abs(number));
                number = Math.Abs(number) + 1;
            }
            else
            {
                Console.WriteLine(-number);
                number = -(number + 1);
            }
        }
    }
}

