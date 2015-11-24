using System;


class PrintCurrentDayOfWeek
{
    static void Main()
    {
        DateTime today = DateTime.Today;        
        Console.WriteLine(today.DayOfWeek);
    }
}
