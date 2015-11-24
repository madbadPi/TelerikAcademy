using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReadIntAndCalcSqrtExHandl
{
    static void Main()
    {
        uint num = 0;
        try
        {
           num = uint.Parse(Console.ReadLine());
            double result = Math.Sqrt(num);
            Console.WriteLine(result);            
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }

    }
}
