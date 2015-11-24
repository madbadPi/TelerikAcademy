using System;

class SortValueDescendingOrder
{
    static void Main()
    {
        Console.WriteLine("Enter first real number:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second real number:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third real number:");
        double c = double.Parse(Console.ReadLine());
        double small = a, big = b, biggest = c;
        if ((a >= b) && (a >= c))
        {
            biggest = a;
            if (b >= c)
            {
                small = c;
                big = b;
            }
            else
            {
                small = b;
                big = c;
            }
        }
        if ((b >= a) && (b >= c))
        {
            biggest = b;
            if (a >= c)
        	{
		        small = c;
                big = a;
	        }
            else
		    {
                small = a;
                big = c;
            }
        }
        if ((c >= b) && (c >=a))
	    {
		    biggest = c;
            if (b >=a )
	        {
		        small = a;
                big = b;		 
	        }
            else
	        {
                small = b;
                big = a;
            }
        }
        Console.WriteLine("The numbers in descending order are: {0} , {1} , {2}", biggest, big, small);
    }
}
