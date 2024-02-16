using System;
using System.Collections.Generic;
using System.Linq;

namespace Algostruct.Algorithms.Sort
{
    public class InsertionSort<T> where T : IComparable<T>
    {
        public static IEnumerable<T> Sort(IEnumerable<T> elements)
        {
            T[] array = elements.ToArray();

            for (int i = 1; i < array.Length; i++)
            {
                int j = i;

                while (j != 0 && (array[j].CompareTo(array[j - 1]) < 0))
                {
                    (array[j], array[j - 1]) = (array[j - 1], array[j]);
                    --j;
                }
            }

            return array;
        }
    }
}
