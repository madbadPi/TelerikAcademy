using System;

class FindMaximalIncrSequence
{
    static void Main()
    {
        Console.Write("Number of elements n=");
        int arrayLength = int.Parse(Console.ReadLine());
        int[] array = new int[arrayLength];
        for (int i = 0; i < arrayLength; i++)
		{
            Console.Write("array[{0}]=", i);
            array[i]= int.Parse(Console.ReadLine());
		}
        int maxLength = 0;
        int tempLength = 1;
        //int[] incrElmntArray = new int[arrayLength];
        int templElmnt = array[0];
        int startIndex = 0;
        int stopIndex = 0;
        for (int i = 1; i < arrayLength; i++)
        {
            if (templElmnt < array[i])
            {
                tempLength++;
            }
            else
            {
                if (tempLength > maxLength)
                {
                    maxLength = tempLength;
                    startIndex = i - maxLength;
                    stopIndex = i - 1;
                }
                tempLength = 1;
            }
            templElmnt = array[i];
        }
        if (tempLength > maxLength)
        {
            maxLength = tempLength;
            startIndex = arrayLength - maxLength;
            stopIndex = arrayLength - 1;
        }
        if (startIndex == stopIndex)
        {
            Console.WriteLine("There is no sequence");
        }
        else
        {
            string stringBefore = "";
            for (int i = startIndex; i <= stopIndex; i++)
            {
                Console.Write(stringBefore + array[i]);
                stringBefore = ", ";
            }
            Console.WriteLine();
        }

    }
 }