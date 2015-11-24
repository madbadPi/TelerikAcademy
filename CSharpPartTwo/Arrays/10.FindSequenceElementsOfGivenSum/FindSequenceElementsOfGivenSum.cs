using System;

class FindSequenceElementsOfGivenSum
{
    static void Main()
    {
        int arrayLength = int.Parse(Console.ReadLine());
        int[] a = new int[arrayLength];
        int count = 0;
        int sum = 0;
        int tempSum = 0;
        int inputSum = int.Parse(Console.ReadLine());
        bool thereIsNoSequence = false;
        for (int j = 0; j < arrayLength; j++)
        {
            Console.Write("array[{0}]=", j);
            a[j] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < arrayLength; i++)
        {
            sum += a[i];
            tempSum = sum;
            if (sum < inputSum)
            {
                if (i == arrayLength - 1)
                {
                    thereIsNoSequence = true;
                    break;
                }                
            }      
            else
            {                
                while (sum > inputSum)
                {
                    sum -= a[count];
                    count++;
                }

            }
            if (sum == inputSum)
            {
                for (int k = count; k <= i; k++)
                {
                    Console.WriteLine(a[k]);
                }
                break;
            }
            else if ((sum < inputSum) && (i == arrayLength - 1))
            {
                thereIsNoSequence = true;                
                break;
            }

        }
        if (thereIsNoSequence)
        {
            Console.WriteLine("There is no sequence that fulfill the condition");
        }
    }
}
