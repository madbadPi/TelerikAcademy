using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class JoroTheRabbit
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(new char[]{' ', ','}, StringSplitOptions.RemoveEmptyEntries );
        int[] inputNumbers = new int[input.Length];
        for (int i = 0; i < inputNumbers.Length; i++)
        {
            inputNumbers[i] = int.Parse(input[i]);
        }
        int bestPath = 0;

        for (int startIndex = 0; startIndex < inputNumbers.Length; startIndex++)
        {
            for (int step = 1; step < inputNumbers.Length; step++)
            {
                int index = startIndex;
                int currentPath = 1;
                int next = (index + step) % inputNumbers.Length;

                while (inputNumbers[index] < inputNumbers[next])//next != startIndex && 
                {
                    currentPath++;
                    index = next;
                    next = (index + step) % inputNumbers.Length;
                }

                if (bestPath < currentPath)
                {
                    bestPath = currentPath;
                }
            }
        }
        Console.WriteLine(best);
    }
}
