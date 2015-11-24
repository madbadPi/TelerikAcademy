using System;

class SumOfSubsetZero
{
    static void Main()
    {
        int[] number = new int[5];
        int sum;
        try
        {
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine("Input a number");
                number[i] = int.Parse(Console.ReadLine());
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input");
            return;
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid input");
            return;
        }
        bool subsetFound = false;
        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] == 0)
                {
                    Console.WriteLine("Subset found: {0}", number[i]);
                    subsetFound = true;                    
                }
        }
        for (int i = 0; i < number.Length; i++)
        {
            for (int j = i+1; j < number.Length; j++)
            {
                sum = number[i] + number[j];
                if (sum == 0)
                {
                    Console.WriteLine("Subset found: {0}, {1}", number[i], number[j]);
                    subsetFound = true;                    
                }
                for (int k = j + 1; k < number.Length; k++)
                {
                    sum = number[i] + number[j] + number[k];
                    if (sum == 0)
                    {
                        Console.WriteLine("Subset found: {0}, {1}, {2}", number[i], number[j], number[k]);
                        subsetFound = true;
                    }
                    for (int l = k + 1; l < number.Length; l++)
                    {
                        sum = number[i] + number[j] + number[k] + number[l];
                        if (sum == 0)
                        {
                            Console.WriteLine("Subset found: {0}, {1}, {2}, {3}", number[i], number[j], number[k], number[l]);
                            subsetFound = true;
                        }
                    }
                }
            }
        }
        if (!subsetFound)
        {
            Console.WriteLine("There is no subset with sum zero");
        }
    }
}
