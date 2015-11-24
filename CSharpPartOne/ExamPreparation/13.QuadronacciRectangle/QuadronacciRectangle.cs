using System;

class QuadronacciRectangle
{
    static void Main()
    {
        long tribonacciNum1 = long.Parse(Console.ReadLine());
        long tribonacciNum2 = long.Parse(Console.ReadLine());
        long tribonacciNum3 = long.Parse(Console.ReadLine());
        long tribonacciNum4 = long.Parse(Console.ReadLine());
        long tribonacciN = 0;
        int line = int.Parse(Console.ReadLine());
        int numsAtLine = int.Parse(Console.ReadLine());
        string emptySpase = "";
        if (numsAtLine == 4)
        {
            Console.Write("{0} {1} {2} {3}\n", tribonacciNum1, tribonacciNum2, tribonacciNum3, tribonacciNum4);
            for (int j = 2; j <= line; j++)
            {
                for (int i = 1; i <= numsAtLine; i++)
                {
                    tribonacciN = tribonacciNum1 + tribonacciNum2 + tribonacciNum3 + tribonacciNum4;
                    tribonacciNum1 = tribonacciNum2;
                    tribonacciNum2 = tribonacciNum3;
                    tribonacciNum3 = tribonacciNum4;
                    tribonacciNum4 = tribonacciN;
                    Console.Write(emptySpase + tribonacciN);
                    emptySpase = " ";
                }
                Console.WriteLine();
                emptySpase = "";
            }
        }
        else
        {
            Console.Write("{0} {1} {2} {3} ", tribonacciNum1, tribonacciNum2, tribonacciNum3, tribonacciNum4);
            int writtenNums = 4;
            for (int j = 1; j <= line; j++)
            {
                for (int i = writtenNums + 1; i <= numsAtLine; i++)
                {
                    tribonacciN = tribonacciNum1 + tribonacciNum2 + tribonacciNum3 + tribonacciNum4;
                    tribonacciNum1 = tribonacciNum2;
                    tribonacciNum2 = tribonacciNum3;
                    tribonacciNum3 = tribonacciNum4;
                    tribonacciNum4 = tribonacciN;
                    Console.Write(emptySpase + tribonacciN);
                    emptySpase = " ";
                }
                Console.WriteLine();
                emptySpase = "";
                writtenNums = 0;
            }
        }
    }
}
