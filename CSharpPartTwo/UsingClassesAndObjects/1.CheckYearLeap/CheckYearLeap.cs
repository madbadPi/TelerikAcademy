using System;

class CheckYearLeap
{
    static void Main()
    {
        int inputYear = int.Parse(Console.ReadLine());
        Console.WriteLine("The year {0} is leap - {1}", inputYear, DateTime.IsLeapYear(inputYear));
    }
}
