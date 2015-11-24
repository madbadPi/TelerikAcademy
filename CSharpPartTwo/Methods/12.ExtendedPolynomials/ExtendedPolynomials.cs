using System;

class ExtendedPolynomials
{
    private static int[] AddPolynomCoeff(int[] a, int[] b)
    {
        if (a.Length > b.Length)
        {
            return AddPolynomCoeff(b, a);
        }

        int[] c = new int[b.Length];
        for (int i = 0; i < b.Length; i++)
        {
            if (i < a.Length)
            {
                c[i] = a[i] + b[i];
            }
            else if (i >= a.Length)
            {
                c[i] = b[i];
            }
        }
        return c;
    }

    private static int[] MultiplyPolynomCoeff(int[] a, int[] b)
    {
        int[] c = new int[a.Length + b.Length - 1];

        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < b.Length; j++)
            {
                c[i + j] += a[i] * b[j];
            }
        }

        return c;
    }

    private static int[] SubtractPolynomCoeff(int[] a, int[] b, bool isReverse = false)
    {
        if (a.Length > b.Length)
        {
            return SubtractPolynomCoeff(b, a, true);
        }

        int[] c = new int[b.Length];

        for (int i = 0; i < b.Length; i++)
        {
            if (i < a.Length && !isReverse)
            {    
                c[i] = a[i] - b[i];
            }
            else if(i < a.Length && isReverse)
            {
                c[i] = b[i] - a[i];
            } 
            else if (i >= a.Length && !isReverse)
            {
                c[i] = - b[i];
            }
            else if(i >= a.Length && isReverse)
            {
                c[i] = b[i];
            } 
        }

        return c;
    }

    private static void PrintResultPolynom(int[] resultPolynomCoeff)
    {
        string symbolBefore = "";
        int i = resultPolynomCoeff.Length - 1;
        for (; i > 0; i--)
        {
            Console.Write(symbolBefore + resultPolynomCoeff[i] + "*x^{0}", i);
            if (resultPolynomCoeff[i-1] >= 0)
            {
                symbolBefore = "+";
            }
            else
            {
                symbolBefore = "";
            }
        }
        Console.Write(symbolBefore + resultPolynomCoeff[i] + "*x^{0}", i);
        Console.WriteLine();
    }
    
    static void Main()
    {
        int[] firstPolynomCoeff = { -1, 25, 65, 0, 10 };//left to right from coefficient infront of the lowest power of x
        int[] secondPolynomCoeff = { -1, 0, 15, 0, 11, -1 };//left to right from coefficient infront of the lowest power of x
        int maxLen = Math.Max(firstPolynomCoeff.Length, secondPolynomCoeff.Length);
        int[] resultPolynomCoeff = new int[maxLen];
        resultPolynomCoeff = AddPolynomCoeff(firstPolynomCoeff, secondPolynomCoeff);
        PrintResultPolynom(firstPolynomCoeff);
        Console.WriteLine("+");
        PrintResultPolynom(secondPolynomCoeff);
        Console.WriteLine(); 
        PrintResultPolynom(resultPolynomCoeff);
        Console.WriteLine(new string('_', 50));

        PrintResultPolynom(firstPolynomCoeff);
        Console.WriteLine("-");
        PrintResultPolynom(secondPolynomCoeff);
        Console.WriteLine();
        resultPolynomCoeff = SubtractPolynomCoeff(firstPolynomCoeff, secondPolynomCoeff);
        PrintResultPolynom(resultPolynomCoeff);
        Console.WriteLine(new string('_', 50));
        
        PrintResultPolynom(firstPolynomCoeff);
        Console.WriteLine("*");
        PrintResultPolynom(secondPolynomCoeff);
        Console.WriteLine();
        resultPolynomCoeff = MultiplyPolynomCoeff(firstPolynomCoeff, secondPolynomCoeff);
        PrintResultPolynom(resultPolynomCoeff);
        Console.WriteLine();
    }
}
