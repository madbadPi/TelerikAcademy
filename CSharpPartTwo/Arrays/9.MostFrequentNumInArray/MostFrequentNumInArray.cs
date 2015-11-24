using System;

class MostFrequentNumInArray
{
    static void Main()
    {
        int arrayLength = int.Parse(Console.ReadLine());
        int[] array = new int[arrayLength];
        int currentCount = 0;
        int maxCount = 0;
        int element = 0;
        bool isThereElement = false;
        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write("array[{0}]=", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < arrayLength; i++)
        {
            for (int j = i+1; j < arrayLength; j++)
            {
                if (array[j] == array[i])
                {
                    currentCount++;
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        element = array[i];
                        isThereElement = true;
                    }
                    
                }
            }
            currentCount = 0;
        }

        if (isThereElement)
	    {
            Console.Write("Most frequent number is {0}({1}times)", element, maxCount+1);
	    }
        else
	    {
            Console.WriteLine("There is no repetitive number");
	    }
       
    }
}
