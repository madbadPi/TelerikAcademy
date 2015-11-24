using System;

class MinMaxAverageSumProduct
{
    static void Main()
    {
        Console.WriteLine("Input the number of numbers");
        int len = int.Parse(Console.ReadLine());
        int[] array = new int[len];
        InputNumbers(array);
        //int[] array = { 1, -20, -5, 10, 100 };
        Console.WriteLine(GetMax(array));
        Console.WriteLine(GetMin(array));
        Console.WriteLine(Average(array));
        Console.WriteLine(Sum(array));
        Console.WriteLine(Multipl(array));
    }

    private static int Multipl(int[] array)
    {        
        int temp = 1 ;
        for (int i = 0; i < array.Length; i++)
        {
            temp = temp*array[i];
        }
        return temp;
    }

    private static int Sum(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }

    private static double Average(int[] array)
    {             
        return (double) Sum(array)/array.Length;
    }
        
    private static int GetMin(int[] array)
    {
        int minValue = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minValue)
            {
                minValue = array[i];
            }
        }
        return minValue;
    }

    private static int GetMax(int[] array)
    {
        int maxValue = 0;
        
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxValue)
            {
                maxValue = array[i];
            }
        }
        return maxValue;
    }

    private static void InputNumbers(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("array[{0}]=", i);
            array[i] = int.Parse(Console.ReadLine());
        }
    }
}
