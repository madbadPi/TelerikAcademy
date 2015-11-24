using System;

class TripleRotationOfDigits
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine());

        for (int count = 1; count <= 3; count++)
        {
            if (k >= 10)
            {
                int lastDigit = k % 10;
                int firstDigits = k / 10;
                string result = "" + lastDigit + firstDigits;
                k = int.Parse(result);
            }
        }
        Console.WriteLine(k);
    }
}
