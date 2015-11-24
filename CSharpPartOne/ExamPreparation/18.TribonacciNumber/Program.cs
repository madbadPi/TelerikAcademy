using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        BigInteger firstTribonacci = BigInteger.Parse(Console.ReadLine());
        BigInteger secondTribonacci = BigInteger.Parse(Console.ReadLine());
        BigInteger thirdTribonacci = BigInteger.Parse(Console.ReadLine());
        BigInteger nTribonacci = 0;
        int elementN = int.Parse(Console.ReadLine()); ;
        if (elementN == 1)
        {
            Console.WriteLine(firstTribonacci);
        }
        if (elementN == 2)
        {
            Console.WriteLine(secondTribonacci);
        }
        if (elementN == 3)
        {
            Console.WriteLine(thirdTribonacci);
        }
        else if( elementN >= 4)
        {
            for (int i = 3; i < elementN; i++)
            {
                nTribonacci = firstTribonacci + secondTribonacci + thirdTribonacci;
                firstTribonacci = secondTribonacci;
                secondTribonacci = thirdTribonacci;
                thirdTribonacci = nTribonacci;
            }
            Console.WriteLine(nTribonacci);
        }
    }
}
