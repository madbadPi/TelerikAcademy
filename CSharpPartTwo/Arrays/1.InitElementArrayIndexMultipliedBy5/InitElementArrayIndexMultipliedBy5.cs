using System;

class Program
{
    static void Main()
    {
        Console.Write("Number of elements n=");
        int arrayLength = int.Parse(Console.ReadLine());
        int[] array = new int[arrayLength];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i * 5;
        }
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("array[{0}]={1}", i, array[i]);
        }               
    }
}
