using System;

class RandomInRange
{
    static void Main()
    {
        Random randNum = new Random();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(randNum.Next(100, 201));
        }
    }
}
