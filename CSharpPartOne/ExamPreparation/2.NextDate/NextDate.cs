using System;

class NextDate
{
    static void Main()
    {
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());
        int maxDays = 30;
        int nextDay = day;
        int nextMonth = month;
        int nextYear = year;
        bool leapYear;
        if (year % 400 == 0)
        {
            leapYear = true;
        }
        else if (year % 100 == 0)
        {
            leapYear = false;
        }
        else if (year % 4 == 0)
        {
            leapYear = true;
        }
        else
        {
            leapYear = false;
        }

        if (month % 2 != 0 && month <= 7 )
        {
            maxDays = 31;
        }
        else if ((month % 2 == 0) && (month != 2))
        {
            maxDays = 30;
        }
        else if ((month == 2) && leapYear)
        {
            maxDays = 29;
        }
        else if ((month == 2) && !leapYear)
        {
            maxDays = 28;
        }
        if (month % 2 != 0 && month > 7)
        {
            maxDays = 30;
        }
        else if ((month % 2 == 0) && (month > 7))
        {
            maxDays = 31;
        }

        //Console.WriteLine(leapYear + " " + maxDays);
        if (day < maxDays)
        {
            nextDay = day + 1;
            nextMonth = month;
            nextYear = year;
        }
        else if (day == maxDays)
        {
            nextDay = 1;
            if (month != 12)
	        {
	        	nextMonth = month + 1;
                nextYear = year;
	        }
            else
            {
                nextMonth = 1;
                nextYear = year + 1;
            }
        }
        Console.WriteLine(nextDay + "." + nextMonth + "." + nextYear);
    }
}
