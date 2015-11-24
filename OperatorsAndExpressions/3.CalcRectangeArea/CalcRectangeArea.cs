using System;

class CalcRectangeArea
{
    static void Main()
    {
        Console.WriteLine("Enter rectangle width ");
        uint recWidth = uint.Parse(Console.ReadLine());
        Console.WriteLine("Enter rectangle hight ");
        uint recHight = uint.Parse(Console.ReadLine());
        Console.WriteLine("The rectangle area is : {0}", recWidth * recHight);
    }
}
