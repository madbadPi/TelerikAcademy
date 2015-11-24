using System;

class CalcNumberWorkdaysInPeriod
{
    static DateTime[] holidays = {
                                     new DateTime(2014, 3, 3), 
                                     new DateTime(2014, 4, 18),
                                     new DateTime(2014, 4, 19),
                                     new DateTime(2014, 4, 20),
                                     new DateTime(2014, 5, 1),
                                     new DateTime(2014, 5, 6),
                                     new DateTime(2014, 5, 24),
                                     new DateTime(2014, 9, 6),
                                     new DateTime(2014, 9, 22),
                                     new DateTime(2014, 11, 1),
                                     new DateTime(2014, 12, 24), 
                                     new DateTime(2014, 12, 25), 
                                     new DateTime(2014, 12, 26),
                                 };    

    private static void CalcWorkDayinPerios(DateTime startDate, DateTime endDate)
    {
        //string[] daysWeek = { "Moday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        if (startDate.DayOfWeek == DayOfWeek.Saturday)
        {
            startDate = startDate.AddDays(2);
        }

        if (startDate.DayOfWeek == DayOfWeek.Sunday)
        {
            startDate = startDate.AddDays(1);
        }

        if (endDate.DayOfWeek == DayOfWeek.Saturday)
        {
            endDate = endDate.AddDays(-1);
        }
        if (endDate.DayOfWeek == DayOfWeek.Sunday)
        {
            endDate = endDate.AddDays(-2);
        }

        int totalDays = (endDate - startDate).Days + 1;
        int weeks = totalDays / 7;
        int busDays = weeks * 5;
        int remDays = totalDays % 7;
        int result = busDays + remDays;
        Console.WriteLine(RemHolidays(startDate, endDate, result));
    }

    private static int RemHolidays(DateTime startDate, DateTime endDate, int result)
    {
        for (int i = 0; i < holidays.Length; i++)
        {
            if (startDate <= holidays[i] && holidays[i] <= endDate 
                && !(holidays[i].DayOfWeek == DayOfWeek.Saturday || holidays[i].DayOfWeek == DayOfWeek.Sunday))
            {
                result--;
            }
        }
        return result;
    }

    static void Main()
    {
        DateTime inputDate = new DateTime();
        DateTime today = DateTime.Today;
        inputDate = DateTime.Parse(Console.ReadLine());
        while ((DateTime.Today - inputDate).Days > 0)
        {
            Console.WriteLine("Error -The end date is before today");
            inputDate = DateTime.Parse(Console.ReadLine());
        }
        CalcWorkDayinPerios(today, inputDate);
    }
}
