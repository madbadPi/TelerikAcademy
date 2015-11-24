using System;

class TribonacciTriangle
{
    static void Main()
    {
        long tribonacciNum1 = long.Parse(Console.ReadLine());        
        long tribonacciNum2 = long.Parse(Console.ReadLine());         
        long tribonacciNum3 = long.Parse(Console.ReadLine());
        long tribonacciN = tribonacciNum1 + tribonacciNum2 + tribonacciNum3;
        int line = int.Parse(Console.ReadLine());
        int numsAtLine = 3;
        string emptySpase = "";
        Console.WriteLine(tribonacciNum1);
        Console.Write(tribonacciNum2 + " " + tribonacciNum3);
        for (int j = 3; j <= line; j++)
        {
            Console.WriteLine();
            for (int i = 0; i < numsAtLine; i++)
            {
                tribonacciN = tribonacciNum1 + tribonacciNum2 + tribonacciNum3;
                tribonacciNum1 = tribonacciNum2;
                tribonacciNum2 = tribonacciNum3;
                tribonacciNum3 = tribonacciN;
                if (i % 2 != 0)
                {
                    emptySpase = " ";
                }
                Console.Write(emptySpase + tribonacciN);
            }
            numsAtLine++;
            emptySpase = "";
        }
    }
}
