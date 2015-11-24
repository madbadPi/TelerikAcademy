using System;
using System.Text;
using System.Globalization;
using System.Threading;

class ReadDateAndCalcDaysBetween
{
    static void Main()
    {               
        string startDate = Console.ReadLine();
        string endDate = Console.ReadLine();
        int days = 0;
        int startDateBeforeEndDate = DateTime.Compare(DateTime.Parse(startDate), DateTime.Parse(endDate));
        if (startDateBeforeEndDate == -1)
        {
            days = (DateTime.Parse(endDate) - DateTime.Parse(startDate)).Days;
        }
        else
        {
            days = (DateTime.Parse(startDate) - DateTime.Parse(endDate)).Days;
        }
        
        Console.WriteLine("{0} days", days);
    }
}
