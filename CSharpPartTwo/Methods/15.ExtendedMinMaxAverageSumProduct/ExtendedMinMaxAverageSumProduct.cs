using System;
using System.Numerics;

class Program
{
    static void Main()
    {        
        int[] arrayInt = { 1, -20, -5, 10, 100 };
        decimal[] arrayDecimal = { 1.23m, 2.56m, -5.6888888m, 10.0m };
        float[] arrayFloat = { 2.56f, 8.97f, 4.12f, 0.1f };
        double[] arrayDouble = { 2.3555, 5.66666, -1.222, 0.000005 };
        byte[] arrayByte = { 1, 2, 5 };
        long[] arrayLong = { 56777777, 5688, 111 };
        Console.WriteLine(GetMax(arrayByte));
        Console.WriteLine(GetMin(arrayByte));
        Console.WriteLine(Average(arrayByte));
        Console.WriteLine(Sum(arrayByte));
        Console.WriteLine(Multipl(arrayByte));
    }

    private static object Multipl<T>(T[] array)
    {
        dynamic temp = 1;
        for (int i = 0; i < array.Length; i++)
        {
            temp = temp * array[i];
        }
        return temp;
    }

    private static object Sum<T>(T[] array)
    {
        dynamic sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }

    private static object Average<T>(T[] array)
    {
        return Convert.ToDouble(Sum(array)) / array.Length;
    }

    private static object GetMin<T>(T[] array) where T : IComparable<T>
    {
        dynamic minIndex = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].CompareTo(array[minIndex]) < 0)
            {
                minIndex = i;
            }
        }
        return array[minIndex];
    }

    private static object GetMax<T>(T[] array) where T : IComparable<T>
    {
        dynamic maxIndex = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].CompareTo(array[maxIndex]) > 0)
            {
                maxIndex = i;
            }
        }
        return array[maxIndex];
    }    
}
