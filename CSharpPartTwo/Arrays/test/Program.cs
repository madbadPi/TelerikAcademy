using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 8; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(Convert.ToString((i & (1 << j)) >> j, 2) + ",");
                    //Console.Write(Convert.ToString((i >> (j - 1)) & 1) + ",");
                }
                Console.WriteLine();
            }

        }
    }
}
