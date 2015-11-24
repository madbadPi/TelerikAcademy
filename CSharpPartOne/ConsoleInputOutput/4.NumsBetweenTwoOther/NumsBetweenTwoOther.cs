using System;

class NumsBetweenTwoOther
{
    static void Main()
    {
        Console.WriteLine("Write the lower limit of an interval");
        int firstNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Write the upper limit of an interval");
        int secondNum = int.Parse(Console.ReadLine());
        int p = (secondNum / 5) - (firstNum / 5);
        if ((firstNum % 5 == 0) || (secondNum % 5 == 0))
        {
            p++;
        }
        Console.WriteLine("Numbers that the reminder of the division by 5 is 0 in the interval[{0},{1}] are:\n", firstNum, secondNum);
        Console.WriteLine("p={0} - including the limits", p);
    }
}
