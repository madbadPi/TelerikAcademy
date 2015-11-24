using System;

class Program
{
    static void Main()
    {
        int row = int.Parse(Console.ReadLine());
        int length = 2*row - 3;
        int halfLength = length/2;
        int dotsBefore = halfLength - 1;
        int dotsAfter = halfLength - 1;
        int asteriskMiddle = 3;
        Console.Write(new string('.', halfLength));
        Console.Write('*');
        Console.WriteLine(new string('.', halfLength));

        for (int i = 0; i < row -2 ; i++)
        {
            Console.Write(new string('.', dotsBefore));
            Console.Write(new string('*', asteriskMiddle));
            Console.Write(new string('.', dotsAfter));
            asteriskMiddle += 2;
            dotsAfter--;
            dotsBefore--;
            Console.WriteLine();
        }
       
        Console.Write(new string('.', halfLength)); 
        Console.Write(new string('*', 1));
        Console.Write(new string('.', halfLength));
    }
}