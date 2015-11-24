using System;

class CalcFactorial
{
    private static void MultiplNums(int[] array, int num)
    {
        int oneOnMind = 0;        
        for (int i = 0; i < array.Length ; i++)
        {
            int temp = (array[i] * num + oneOnMind);
            if (temp > 9)
            {
                array[i] = temp % 10;
                oneOnMind = temp / 10;
            }
            else
            {
                array[i] = temp;
                oneOnMind = 0;
            }           
        }
    }

    private static void PrintArr(int[] array, int num)
    {

        int counter = 0;
        while (array[counter] == 0)
        {
            counter++;
        }
        for (int j = counter; j < array.Length; j++)
        {
            Console.Write(array[j]);
        }
        Console.WriteLine(" " + num);
    }


    static void Main(string[] args)
    {
        for (int num = 1; num <= 100; num++)
        {
            int[] arr = new int[1000];
            arr[0] = 1;
            for (int i = 1; i <= num; i++)
            {                
                MultiplNums(arr, i);                
            }
            Array.Reverse(arr);
            PrintArr(arr, num);
        }
    }
}
