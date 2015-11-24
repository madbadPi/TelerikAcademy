using System;

class EuclideanAlgorithm
{
    static void Main()
    {
        int firstNum;
        int secondNum;
        Console.WriteLine("Enter first number");
        firstNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number");
        secondNum = int.Parse(Console.ReadLine());
        int GCD = 0;
        if (firstNum == 0 || secondNum == 0)
        {
            Console.WriteLine("Error");
        }
        else
        {
            if (firstNum < secondNum)
            {
                int greather = secondNum;
                secondNum = firstNum;
                firstNum = greather;
            }
            while (secondNum != 0)
            {
                GCD = firstNum % secondNum;
                firstNum = secondNum;
                if (GCD == 0)
                {
                    GCD = Math.Abs(secondNum);
                    secondNum = 0;
                }
                else
                {
                    secondNum = GCD;
                } 
        }

        }
        Console.WriteLine("The greatest common divisor is {0}", GCD);        
    }
}
