namespace ExtensionMethods
{
    using System;
    using System.Collections.Generic;

    public static class IEnumExtensions
    {
        public static decimal Sum<T>(this IEnumerable<T> collection)
        {
            decimal result = 0;
            foreach (var item in collection)
            {
                result += Convert.ToDecimal(item);
                //result += (dynamic)item;
            }
            return result;
        }

        public static decimal Product<T>(this IEnumerable<T> collection)
        {
            decimal result = 1;
            foreach (var item in collection)
            {
                result *= Convert.ToDecimal(item);
                //result *= (dynamic)item;
            }
            return result;
        }

        public static T Min<T>(this IEnumerable<T> collection) where T : IComparable<T>
        {
            T minValue = default(T);
            bool isFirstElement = true;
            foreach (var item in collection)
            {
                if (isFirstElement)
                {
                    minValue = item; 
                    isFirstElement = false;
                }
                else
                {
                    if (item.CompareTo(minValue) < 0)
                    {
                        minValue = item;
                    }  
                }                              
            }
            return minValue;
        }

        public static T Max<T>(this IEnumerable<T> collection) where T : IComparable<T>
        {
            T maxValue = default(T);
            bool isFirstElement = true;
            foreach (var item in collection)
            {
                if (isFirstElement)
                {
                    maxValue = item;
                    isFirstElement = false;
                }
                else
                {
                    if (item.CompareTo(maxValue) > 0)
                    {
                        maxValue = item;
                    }
                }
            }
            return maxValue;
        }

        public static decimal Average<T>(this IEnumerable<T> collection)
        {
            decimal sum = 0;
            int counter = 0;
            foreach (var item in collection)
            {
                sum += Convert.ToDecimal(item);
                counter++;
            }
            return sum / counter;
        }
    }
}
