using System;

class FindSubsetWithGivenSum
{
    static int n = int.Parse(Console.ReadLine());
    static int sum = int.Parse(Console.ReadLine());

    private static void GenerateCombination(int[] array, int[] inputArray, int index,int next, int k)
    {
        if (index == k)
        {
            SumCombinationElement(array, k);
        }
        else
        {
            for (int i = next; i < array.Length; i++)
            {                  
                array[index] = inputArray[i];                
                GenerateCombination(array, inputArray, index + 1, i + 1, k);
            }
        }
    }

    private static void SumCombinationElement(int[] array, int k)
    {
        int currentSum = 0;        
        for (int i = 0; i < k; i++)
        {
            currentSum += array[i];
        }
        if (currentSum == sum)
        {            
            PrintSubSet(array, k);
        }
    }

    private static void PrintSubSet(int[] array, int k)
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
        for (int k = 2; k <= n; k++)
        {                        
            GenerateCombination(combination, inputArray, 0, 0, k);
        }
    }
}
