using System;
using System.Collections.Generic;

class RemMinElementsThatRemainArraySorted
{

    private static void PrintList(List<int> list)
    {
        foreach (int num in list)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    private static bool isListSorted(List<int> list)
    {
        bool isListSortedFlag = true;
        for (int i = 0; i < list.Count - 1; i++)
        {
            if (list[i] > list[i + 1])
            {
                isListSortedFlag = false;
            }
        }
        return isListSortedFlag;
    }

    static void Main()
    {
        List<int> arrNums = new List<int>();
        int arrLen = int.Parse(Console.ReadLine()); ;
        for (int l = 0; l < arrLen; l++)
        {
            arrNums.Add(int.Parse(Console.ReadLine()));
        }
        List<int> result = new List<int>();
        List<int> tempList = new List<int>();
        int maxCombination = (int)Math.Pow(2, arrNums.Count) - 1;
        int maxCount = 0;

        for (int i = 1; i <= maxCombination; i++)
        {            
            tempList.Clear();
            int currentCount = 0;
            for (int j = 0; j < arrNums.Count; j++)
            {
                int bit = (i & (1 << j)) >> j;
                if (bit == 1)
                {
                    tempList.Add(arrNums[j]);
                    currentCount++;
                }
            }
            if (currentCount > maxCount && isListSorted(tempList))
            {
                result.Clear();
                for (int k = 0; k < tempList.Count; k++)
			    {
                    result.Add(tempList[k]);
                }
                maxCount = currentCount;
                
            }            
            currentCount = 0;          
        }
        PrintList(result);
    }
}
