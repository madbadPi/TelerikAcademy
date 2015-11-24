using System;

class CompareCharArraysLetters
{
    static void Main()
    {
        int firstArrayLength = int.Parse(Console.ReadLine());
        int secondArrayLength = int.Parse(Console.ReadLine());
        char[] firstArray = new char[firstArrayLength];
        char[] secondArray = new char[secondArrayLength];
        bool areEqualArrays = true;

        for (int i = 0; i < firstArray.Length; i++)
        {
            firstArray[i] = char.Parse(Console.ReadLine());
        }

        for (int i = 0; i < secondArray.Length; i++)
        {
            secondArray[i] = char.Parse(Console.ReadLine());
        }

        for (int i = 0; i < Math.Min(firstArrayLength, secondArrayLength); i++)
        {
            if (firstArray[i] != secondArray[i])
            {
                areEqualArrays = false;
                if (firstArray[i] < secondArray[i])
                {
                    Console.WriteLine("The first array is lexicografically before the second");
                    break;
                }
                if (firstArray[i] > secondArray[i])
                {
                    Console.WriteLine("The second array is lexicografically before the first");
                    break;           
                }
            }
        }
        if (areEqualArrays && firstArrayLength == secondArrayLength)
        {
            Console.WriteLine("They are equal");
        }
        else if (areEqualArrays && firstArrayLength < secondArrayLength)
        {
            Console.WriteLine("The first array is lexicografically before the second!");
        }
        else if (areEqualArrays && firstArrayLength > secondArrayLength)
	    {
            Console.WriteLine("The second array is lexicografically before the first!");
        }
  
    }
}
