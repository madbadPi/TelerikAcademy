using System;

class CountGivenNumInArray
{
    private static int CountNumberInArray(int[] array, int number)
    {
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                counter++;
            }
        }
        return counter;
    }

    static void Main(string[] args)
    {
        Console.Write("Type the lenght of the array ");
        int arrLen = int.Parse(Console.ReadLine());
        //int[] arr = {1, 2, 3, 4, 1, 1, 5, 5, 6, -12, 100};
        int[] arr = new int[arrLen];
        for (int i = 0; i < arrLen; i++)
        {
            Console.Write("array[{0}]=", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Type the number ");
        int inputNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Found {0} times", CountNumberInArray(arr, inputNum));
    } 
}
