using System;

class BonusPoints
{
    static void Main()
    {
        int number;
        try
        {
            Console.WriteLine("Enter a number");
            number = int.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("error");
            return;
        }
        catch (OverflowException)
        {
            Console.WriteLine("error");
            return;
        }
        switch (number)
        {
            case 1: 
            case 2: 
            case 3:
                number = number * 10 ;
                Console.WriteLine(number);
                break;
            case 4: 
            case 5:
            case 6:
                number = number * 100;
                Console.WriteLine(number);
                break;
            case 7: 
            case 8:
            case 9:
                number = number * 1000;
                Console.WriteLine(number);
                break;
            case 0: 
                Console.WriteLine("The number is not a digit");
                break;
            default: Console.WriteLine("error");
                break;
        }
    }
}