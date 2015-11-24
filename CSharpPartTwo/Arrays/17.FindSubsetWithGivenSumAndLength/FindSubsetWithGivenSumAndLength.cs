using System;

class FindSubsetWithGivenSumAndLength
{
    static int n = int.Parse(Console.ReadLine());
    static int k = int.Parse(Console.ReadLine());
    static bool isThereSubset = false;
    static int sum = int.Parse(Console.ReadLine());    

    private static void GenerateCombination(int[] array, int[] inputArray, int index,int next)
    {
        if (index == k)
        {
            SumCombinationElement(array);
        }
        else
        {
            for (int i = next; i < array.Length; i++)
            {                  
                array[index] = inputArray[i];                
                GenerateCombination(array, inputArray, index + 1, i + 1);
            }
        }
    }

    private static void SumCombinationElement(int[] array)
    {
        int currentSum = 0;              
        for (int i = 0; i < k; i++)
        {
            currentSum += array[i];
        }
        if (currentSum == sum)
        {
            isThereSubset = true;
            PrintSubSet(array);
        }
    }

    private static void PrintSubSet(int[] array)
    {
        string beforeNum = "Yes ->";
        for (int i = 0; i < k; i++)
        {
            Console.Write(beforeNum + array[i]);
            beforeNum = "+";
        }
        Console.WriteLine();
        beforeNum = "";
    }

    static void Main()
    {
        int[] inputArray = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("a[{0}]=", i);
            inputArray[i] = int.Parse(Console.ReadLine());
        }

        int[] combination = new int[n];
        GenerateCombination(combination, inputArray, 0, 0);
        if (!isThereSubset)
        {
            Console.WriteLine("There is no subset that complies with the conditions");
        }
    }
}