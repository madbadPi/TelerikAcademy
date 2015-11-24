using System;

class AddTwoPositiveNums
{
    static void Main()
    {
        string firstNum = Console.ReadLine();
        string secondNum = Console.ReadLine();
        int maxLen = Math.Max(firstNum.Length, secondNum.Length) + 1;
        int[] firstNumArr = new int[maxLen];
        int[] secondNumArr = new int[maxLen];
        ReverseDigits(firstNumArr, firstNum);
        ReverseDigits(secondNumArr, secondNum);
        int[] resultArray = new int[maxLen];
        resultArray = AddArraysOfDidigts(firstNumArr, secondNumArr);        
        PrintDidigts(resultArray);
    }

    private static void PrintDidigts(int[] array)
    {
        int counter = array.Length - 1;
        while (array[counter] == 0)
        {
            counter--;
        }
        for (int j = counter; j >= 0; j--)
        {
            Console.Write(array[j]);
        }
        Console.WriteLine();
    }


    private static int[] AddArraysOfDidigts(int[] arrayOne, int[] arryTwo)
    {        
        int[] result = new int[arrayOne.Length];
        int sum = 0;
        for (int i = 0; i < arrayOne.Length; i++)
        {
            sum += arrayOne[i] + arryTwo[i];
            if (sum <= 9)
            {
                result[i] = sum;
                sum = 0;
            }
            else
            {
                result[i] = sum % 10;
                sum = 1;
            }

        }
        return result;
    }

    private static void ReverseDigits(int[] array, string num)
    {
        for (int i = 0; i < num.Length; i++)
        {
            array[i] = num[num.Length - 1 - i] - 48;
        }
    }

}
