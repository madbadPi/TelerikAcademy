namespace Matrix
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Matrix<int> a = new Matrix<int>(2, 2);
            a[0, 0] = 1;
            a[0, 1] = 2;
            a[1, 0] = 1;
            a[1, 1] = 2;

            Matrix<int> b = new Matrix<int>(2, 2);
            b[0, 0] = 0;
            b[0, 1] = 0;
            b[1, 0] = 0;
            b[1, 1] = 0;

            Matrix<int> c = a + b;
            Console.WriteLine(c);
            c = a - b;
            Console.WriteLine(c);
            c = a * b;
            Console.WriteLine(c);

            if (c)
            {
                Console.WriteLine("The result matrix is not empty"); 
            }
            else
            {
                Console.WriteLine("The result matrix is empty");
            }
        }
    }
}
