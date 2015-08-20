

namespace IEnumerableExtensions.Extensions
{
    using System;
    using System.Collections.Generic;
    public static class IEnumerableExtensions
    {
        //Sum
        public static T Sum<T>(this IEnumerable<T> enumeration) where T: IComparable<T>
        {
            decimal sum = new decimal();

            foreach (var item in enumeration)
            {
                sum += Convert.ToDecimal(item);
            }
            return (T)Convert.ChangeType(sum, typeof(T));
        }

        //Product
        public static T Product<T>(this IEnumerable<T> enumeration) where T: IComparable<T>
        {
            decimal product = 1;

            foreach (var item in enumeration)
            {
                product *= Convert.ToDecimal(item);
            }

            return (T)Convert.ChangeType(product, typeof(T));
        }

        //Min
        public static T Min<T>(this IEnumerable<T> enumeration) where T: IComparable<T>
        {
            decimal minResult = decimal.MaxValue;

            foreach (var item in enumeration)
            {
                if (Convert.ToDecimal(item) <= minResult)
                {
                    minResult = Convert.ToDecimal(item);
                }
            }
            return (T)Convert.ChangeType(minResult,typeof(T));
        }
        //Max
        public static T Max<T>(this IEnumerable<T> enumeration) where T: IComparable<T>
        {
            decimal maxResult = decimal.MinValue;

            foreach (var item in enumeration)
            {
                if (Convert.ToDecimal(item)>=maxResult)
                {
                    maxResult = Convert.ToDecimal(item);
                }
            }
            return (T)Convert.ChangeType(maxResult, typeof(T));
        }

        //Average

        public static decimal Average<T>(this IEnumerable<T> enumeration) where T: IComparable<T>
        {
            decimal counter = 0;
            decimal sum = Convert.ToDecimal(enumeration.Sum<T>());
            decimal result = new decimal();

            foreach (var item in enumeration)
            {
                counter++;
            }

            result = sum / counter;

            return result;
        }
    }
}
