using System;
using System.Globalization;
using System.Threading;

class DateTimeParse
{
    static void Main()
    {
        string dateStr = Console.ReadLine();
        DateTime inputDate = DateTime.ParseExact(dateStr, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        inputDate = inputDate.AddHours(6.50);
        Console.WriteLine("{1} {0:dd.MM.yyyy HH:mm:ss}", inputDate, inputDate.DayOfWeek);
    }
}
