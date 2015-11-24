using System;
using System.Text;

class StringFormat
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        string s = String.Empty;

        s = String.Format("{0,15:D}", num);
        Console.WriteLine(s);

        s = String.Format("{0,15:X}", num);
        Console.WriteLine(s);

        s = String.Format("{0,15:P}", num);
        Console.WriteLine(s);

        s = String.Format("{0,15:E}", num);
        Console.WriteLine(s);
    }
}
