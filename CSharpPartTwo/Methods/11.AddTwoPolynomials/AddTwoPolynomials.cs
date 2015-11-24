using System;

class AddTwoPolynomials
{
    private static void PrintResultPolynom(int[] resultPolynomCoeff)
    {
        string symbolBefore = "";
        for (int i = 0; i < resultPolynomCoeff.Length; i++)
        {
            Console.Write(symbolBefore + resultPolynomCoeff[i] + "*x^{0}", i);
            symbolBefore = "+";
        }
        Console.WriteLine();
    }

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

    static void Main()
    {
        //int inputFirstPolynomCoef = int.Parse(Console.ReadLine());
        //int inputSecondPolynomCoef = int.Parse(Console.ReadLine());
        int[] firstPolynomCoeff = { 0, 25, 65, 0, 10 };//left to right from coefficient infront of the lowest power of x
        int[] secondPolynomCoeff = { -2, 0, 15, 0 };//left to right from coefficient infront of the lowest power of x
        int maxLen = Math.Max(firstPolynomCoeff.Length, secondPolynomCoeff.Length);
        int[] resultPolynomCoeff = new int[maxLen];
        resultPolynomCoeff = AddPolynomCoeff(firstPolynomCoeff, secondPolynomCoeff);
        PrintResultPolynom(resultPolynomCoeff);
    }
}