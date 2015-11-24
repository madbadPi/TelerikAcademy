using System;

class FindMaxSequenceEqualElements
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
        int tempArrayLength = 1;
        int sameElmnt = 0;
        int templElmnt = array[0];
        for (int i = 1; i < arrayLength; i++)
        {
            if (templElmnt == array[i])
            {
                tempArrayLength++;
            }
            else
            {
                if (tempArrayLength > maxLength)
                {
                    sameElmnt = array[i - 1];
                    maxLength = tempArrayLength;
                }
                tempArrayLength = 1;
            }
            templElmnt = array[i];
        }
        if (tempArrayLength > maxLength)
        {
            sameElmnt = array[arrayLength - 1];
            maxLength = tempArrayLength;
        }

        if (maxLength > 1)
        {
            Console.Write("The sequence is : ");
            string stringBefore = "";
            for (int i = 0; i < maxLength; i++)
            {
                Console.Write(stringBefore + sameElmnt);
                stringBefore = ", ";
            }
            Console.WriteLine();
        }
    }
}
