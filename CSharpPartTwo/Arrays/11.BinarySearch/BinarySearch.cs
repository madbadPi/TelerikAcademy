using System;

class BinarySearch
{
    static void Main()
    {
        int aLength = int.Parse(Console.ReadLine());
        int[] a = new int[aLength];
        int inputElement = int.Parse(Console.ReadLine());

        for (int i = 0; i < aLength; i++)
	    {
			Console.Write("a[{0}]=", i);
            a[i] = int.Parse(Console.ReadLine());
		}
        int midPoint = 0;
        int minIndex = 0;
        int maxIndex = aLength - 1;

        for (int i = 0; i < aLength - 1; i++)
        {
            int minPos = i;
            for (int j = i + 1; j < aLength; j++)
            {
                if (a[j] < a[minPos])
                {
                    minPos = j;
                }
            }

            if (i != minPos)
            {
                int tempNum = a[i];
                a[i] = a[minPos];
                a[minPos] = tempNum;
            }
        }
        do
	    {
            midPoint = (minIndex + maxIndex)/2;
            if (inputElement > a[midPoint])
	        {
                minIndex = midPoint + 1;
            }
            else
	        {
                maxIndex = midPoint - 1;
	        }
            if (a[midPoint] == inputElement)
	        {
	        	 Console.WriteLine("The index of the input element is {0}", midPoint);
                 break;
	        }	             
	    } while (minIndex <= maxIndex);
    }
}