using System;

class PrintNums1toN
{
    static void Main()
    {
        int n;
        string consoleInput;
        do
	    {
            Console.Write("Enter valid number n=");
            consoleInput = Console.ReadLine();                
	    } 
        while (!int.TryParse(consoleInput, out n) || n<1);
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Number :{0}", i);
        }
    }
}