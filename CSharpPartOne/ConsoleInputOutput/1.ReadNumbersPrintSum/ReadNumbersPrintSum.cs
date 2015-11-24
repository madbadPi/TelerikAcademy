using System;

class ReadNumbersPrintSum
{
    static void Main()
    {
        Console.WriteLine("Write 3 integer numbers:");
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        int number3 = int.Parse(Console.ReadLine());
        Console.WriteLine("The sum is:\n{0}+{1}+{2}={3}", number1, number2, number3, number1 + number2 + number3);
    }
}