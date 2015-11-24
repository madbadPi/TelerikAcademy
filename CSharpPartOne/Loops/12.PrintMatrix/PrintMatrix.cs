using System;

class PrintMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int number;
        if (n <= 0 || n >= 20)
        {
            Console.WriteLine("erro");
        }
        else
        {
            for (int row = 0; row < n; row++)
            {
                number = row + 1;
                for (int col = 0; col < n; col++)
                {
                    if (number > 9)
                    {
                        Console.Write(number + "  ");
                    }
                    else
                    {
                        Console.Write(" " + number + "  ");
                    }
                        number++;
                }
                Console.WriteLine();
            }
        }        
    }
}
