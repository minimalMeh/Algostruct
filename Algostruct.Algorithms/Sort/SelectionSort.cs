using System;
using System.Collections.Generic;
using System.Linq;

namespace Algostruct.Algorithms.Sort
{
    public class SelectionSort<T> where T : IComparable<T>
    {
        public static IEnumerable<T> Sort(IEnumerable<T> elements)
        {
            T[] array = elements.ToArray();

            for (int i = 0; i < array.Length - 1; i++)
            {
                int low = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    // array[j] < array[low]
                    if (array[j].CompareTo(array[low]) < 0)
                    {
                        low = j;
                    }
                }

                (array[low], array[i]) = (array[i], array[low]);
            }

            return array;
        }
    }
}
