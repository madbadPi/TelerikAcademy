using System;

class MaxValue
{
    private static int GetMax(int num1, int num2)
    {
        int maxNum = Convert.ToInt32(Math.Max(num1, num2));
        return maxNum;
    }

    static void Main()
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        int thirdNum = int.Parse(Console.ReadLine());
        int max = GetMax(GetMax(firstNum, secondNum), thirdNum);
        Console.WriteLine("The biggest number is {}", max);
    }   
}
