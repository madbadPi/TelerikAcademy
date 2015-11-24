using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TwoIsBetterThanOne
{
    static bool IsPalindrom(long number)
    {
        string num = number.ToString();
        for (int i = 0; i < num.Length/2; i++)
        {
            if (num[i] != num[num.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
     static int  FindLuckyNumbers(long lowerBound, long upperBound)
     {
         long max = upperBound;//100000000000000000;
         int left = 0;
         var numbers = new List<long>{3,5};
         int count = 0;
         while (left < numbers.Count)
         {
             int right = numbers.Count;
             for (int i = left; i < right; i++)
             {
                 if (numbers[i] < max)
                 {
                     numbers.Add(numbers[i] * 10 + 3);
                     numbers.Add(numbers[i] * 10 + 5);
                 }
             }
             left = right;
         }
         foreach (var num in numbers)
         {
             if (IsPalindrom(num) && num >= lowerBound && num <= upperBound)
             {
                 count++;
             }
         }

         return count;
         
     }

    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] tokens = input.Split();
        long lowerBound = long.Parse(tokens[0]);
        long upperBound = long.Parse(tokens[1]);

        int count = FindLuckyNumbers(lowerBound, upperBound);
        Console.WriteLine(count);
                
        
    }
}