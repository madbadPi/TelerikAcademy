using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class KaspichanNumbers
{
    static void Main()
    {
        ulong num = ulong.Parse(Console.ReadLine());
        List<string> kaspichanNums = new List<string>();
        for (char i = 'A'; i <= 'Z'; i++)
        {
            kaspichanNums.Add(i.ToString());
        }

        for (char i ='a'; i <= 'i'; i++)
        {
            for (int j = 'A'; j <= 'V'; j++)
			{
                kaspichanNums.Add(i.ToString() + j.ToString());
			}
        }

        string result = String.Empty;
        if (num == 0)
        {
            result = "A";
        }
        while (num > 0)
        {    
            result = kaspichanNums[(int)(num % 256)] + result;         
            num = num / 256;
        }
        Console.WriteLine(result);
    }
}
