using System;

class Program
{
    static void Main(string[] args)
    {
        int anacciFirst = Convert.ToChar(Console.ReadLine()) - 64;
        int anacciSecond = Convert.ToChar(Console.ReadLine()) - 64;
        int anacciN = 0;
        int anacciSum = 0;
        int lines = int.Parse(Console.ReadLine());
        string emptySpace = "";
        Console.WriteLine((char)(anacciFirst + 64));
        for (int i = 2; i <= lines; i++)
        {
            for (int j = 1; j <= 2; j++)
            {
                anacciN = anacciFirst + anacciSecond;
                anacciFirst = anacciSecond;
                anacciSecond = anacciN;
                while (anacciFirst > 26 )
                {
                    anacciFirst -= 26;

                }
                    Console.Write((char)(anacciFirst + 64));
                    Console.Write(emptySpace);
            }
            Console.WriteLine();
            emptySpace += " ";
        }
    }
}