using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ReadNum
{
    private static int ReadNums(int minValue, int maxValue, int number)
    {

        if (number < minValue || number > maxValue)
        {
            throw new ArgumentOutOfRangeException();
        }
        return number;
    }

    static void Main(string[] args)
    {
        try
        {
            int minValue = 1;
            int maxValue = 20;
            for (int i = 0; i < 10; i++)
            {
                int n = int.Parse(Console.ReadLine());
                minValue = ReadNums(minValue, maxValue, n);
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid number");
        }        
    }
}
