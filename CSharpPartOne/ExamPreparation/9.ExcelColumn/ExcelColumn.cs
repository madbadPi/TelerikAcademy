using System;

class ExcelColumn
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] symbols = new int[n];
        long index = 0;
        for (int i = 0; i < n; i++)
        {
            int a = Convert.ToChar(Console.ReadLine()) - 64;
            symbols[i] = a;
        }
        index = symbols[n-1];
        long expression = 1;
        for (int j = 1; j <= n-1; j++)
			{
                
                expression *= 26;
                index += ((symbols[n-j-1])*expression);
			}
        Console.WriteLine(index);

    }
}
