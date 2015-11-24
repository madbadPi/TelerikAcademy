using System;

class FloatingPointNumCompare
{
    static void Main()
    {
        Console.WriteLine("Type first real number");
        decimal a = Convert.ToDecimal((Console.ReadLine()));
        Console.WriteLine("Type second real number");
        decimal b = Convert.ToDecimal((Console.ReadLine()));
        bool sameNum = Math.Abs(a - b) < 0.000001m;
        if (sameNum)
	    {
            Console.WriteLine("The floating point numbers are the same with precision of 0.000001 " + sameNum);
	    }
        else
        {     
            Console.WriteLine("The floating point numbers are the same with precision of 0.000001 " + sameNum);
    	}
        
    }
}

