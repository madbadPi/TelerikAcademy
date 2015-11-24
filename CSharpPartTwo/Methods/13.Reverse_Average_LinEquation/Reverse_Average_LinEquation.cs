using System;

class Reverse_Average_LinEquation
{
    private static void InputConditionsLinEquatione()
    {
        Console.WriteLine("Type coefficient a before x");
        int coeff1 = int.Parse(Console.ReadLine());
        while (coeff1 == 0)
        {
            Console.WriteLine("Wrong input, the coefficient before x shouldn't be equal to 0");
            coeff1 = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Type coefficient b");
        int coeff2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Result");
        Console.WriteLine(SolveLinEquation(coeff1, coeff2));
    }

    private static void InputConditionsAverage()
    {
        Console.WriteLine("How long is the sequence ");
        int len = int.Parse(Console.ReadLine());
        while (len <= 0)
        {
            Console.WriteLine("Wrong input, the sequence should not be empty");
            len = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Input sequence:");
        int[] array = new int[len];
        for (int i = 0; i < len; i++)
        {
            Console.Write("array[{0}]=", i);
            array[i] = int.Parse(Console.ReadLine());
            if (array[i] < 0)
            {
                array[i] = - array[i];
            }
        }
        Console.WriteLine("Result");
        Console.WriteLine(Average(array));
    }

    private static void InputConditionsReverseDigits()
    {
        Console.WriteLine("Input number");
        string inputString = Console.ReadLine();
        int inputNum = int.Parse(inputString);        
        while (inputNum < 0)
        {
            Console.WriteLine("Wrong input, the number shouldn't be negative");
            inputString = Console.ReadLine();
            inputNum = int.Parse(inputString);
        }
        int[] numArray = new int[inputString.Length];
        ReverseDigits(numArray, inputNum);
    }

    private static double SolveLinEquation(int a, int b)
    {        
        double result = (double) -b / a;
        return result;
    }

    private static double Average(int[] array)
    {        
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        double result = (double)sum / array.Length;
        return result;
    }

    private static void ReverseDigits(int[] arr, int num)
    {
        int counter = 0;
        int lastNum = 0;
        while (num / 10 != 0)
        {
            lastNum = num - (num / 10) * 10;
            arr[counter] = lastNum;
            counter++;
            num = (num - lastNum) / 10;
        }
        arr[counter] = num;
        PrintArray(arr);
    }

    private static void PrintArray(int[] arr)
    {
        Console.WriteLine("Result");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.WriteLine("Choose which task to solve\n1:Revers the digits of number\n2:Calculate the average of sequence\n3:Solves a linear equation");
        int inputOption = int.Parse(Console.ReadLine());
        while (inputOption != 1 && inputOption != 2 && inputOption != 3)
        {
            Console.WriteLine("Wrong input");
            inputOption = int.Parse(Console.ReadLine());
        }        
        if (inputOption == 1) InputConditionsReverseDigits();
        else if (inputOption == 2) InputConditionsAverage();
        else if (inputOption == 3) InputConditionsLinEquatione();
    }
}