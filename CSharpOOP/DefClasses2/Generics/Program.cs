namespace Generics
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> newList = new GenericList<int>(7);
            //Console.WriteLine(newList.Capacity);
            //Console.WriteLine(newList.Count);
            newList.Add(1);
            newList.Add(-2);
            newList.Add(3);
            newList.Add(4);
            newList.Add(5);
            newList.Add(6);
            newList.Add(7);
            newList.InsertAt(-11, 7);
            Console.WriteLine(newList.Max());
            Console.WriteLine(newList.Min());
            
        }
    }
}
