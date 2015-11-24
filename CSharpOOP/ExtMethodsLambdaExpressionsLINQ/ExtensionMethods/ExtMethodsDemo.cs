namespace ExtensionMethods
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    public class ExtMethodsDemo
    {
        static void Main()
        {
            //test for Substring extension method
            StringBuilder demoString = new StringBuilder("Hello Kitty");
            Console.WriteLine(demoString.SubString(9, 2));

            //test for sum, product, min, max and average extension methods for IEnumerable<T>
            int[] demoCollection = {-2, -1};
            //Console.WriteLine(IEnumExtensions.Sum(demoCollection));
            //Console.WriteLine(IEnumExtensions.Product(demoCollection));
            Console.WriteLine(IEnumExtensions.Min(demoCollection));
            Console.WriteLine(IEnumExtensions.Max(demoCollection));
            //Console.WriteLine(IEnumExtensions.Average(demoCollection));
        }
    }
}
