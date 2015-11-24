namespace HandlingExceptions
{
    using System;
    using System.Collections.Generic;

    public class HandlingExceptionProgram
    {
        static void Main()
        {
            //Write a sample application 
            //that demonstrates the InvalidRangeException<int> by 
            //entering numbers in the range [1..100]
            int start = 1;
            int end = 100;
            int num;
            Console.WriteLine("Enter number in the range [1,100]");
            try
            {
                num = int.Parse(Console.ReadLine());
                if (num < start || num > end )
                {
                    throw new InvalidRangeException<int>("The number have to be in the range", start, end);
                }
            }
            catch (InvalidRangeException<int> ex)
            {                
                Console.Write(ex.Message);
                Console.WriteLine(" [{0},{1}]", start, end);
            }

            //Write a sample application that demonstrates
            //InvalidRangeException<DateTime> by entering dates in the range [1.1.1980 … 31.12.2013].
            DateTime startDate = new DateTime(1980, 1, 1);
            DateTime endDate = new DateTime(2013, 12, 31);

            Console.WriteLine("Enter date in the range [1.1.1980, 31.12.2013]");
            try
            {
                DateTime newDate = new DateTime();
                newDate = DateTime.Parse(Console.ReadLine());

                if (newDate < startDate || newDate > endDate)
                {
                    throw new InvalidRangeException<DateTime>("The date have to be in the range", startDate, endDate);
                }
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.Write(ex.Message);
                Console.WriteLine(" [{0},{1}]", startDate.ToShortDateString(), endDate.ToShortDateString());                
            }
        }
    }
}
