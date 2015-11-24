namespace BitArray
{
    using System;

    public class BitArrayTest
    {
        static void Main()
        {
            BitArray64 firstNum = new BitArray64(9223372036854775808);
            BitArray64 secondNum = new BitArray64(3);
            if (firstNum != secondNum)
            {
                Console.WriteLine("The");
            }
            foreach (var item in secondNum)
            {
                Console.Write(item);

            }
        }
    }
}
