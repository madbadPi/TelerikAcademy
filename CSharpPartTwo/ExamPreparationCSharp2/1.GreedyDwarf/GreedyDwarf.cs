using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GreedyDwarf
{
    private static long ProccessPattern(int[] valley)
    {
        string[] rawNums = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        int[] pattern = new int[rawNums.Length];
        for (int i = 0; i < rawNums.Length; i++)
        {
            pattern[i] = int.Parse(rawNums[i]);
        }

        bool[] isVisited = new bool[valley.Length];
        long coindSum = 0;
        coindSum += valley[0];
        isVisited[0] = true;
        int currentPosition = 0;
        int nextMove = 0;
        while (true)
        {
            for (int i = 0; i < pattern.Length; i++)
            {
                nextMove = currentPosition + pattern[i];
                if (nextMove >= 0 && nextMove < valley.Length && !isVisited[nextMove])
                {
                    coindSum += valley[nextMove];
                    isVisited[nextMove] = true;
                    currentPosition = nextMove;
                }
                else
                {
                    return coindSum;
                }                
            }
        }     
        
    }
    static void Main()
    {
        string[] valley = Console.ReadLine().Split(new char[] { ' ', ','}, StringSplitOptions.RemoveEmptyEntries);
        int[] valleyNum = new int[valley.Length];
        for (int i = 0; i < valley.Length; i++)
        {
            valleyNum[i] = Int32.Parse(valley[i]);
        }
        int numberOfPattern = int.Parse(Console.ReadLine());

        long bestSum = long.MinValue;// vaghno

        for (int i = 0; i < numberOfPattern; i++)
        {
            long sum = (ProccessPattern(valleyNum));
            if (sum > bestSum)
            {
                bestSum = sum;
            }
        }
        Console.WriteLine(bestSum);        
    }
}
