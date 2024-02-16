using System;
using System.Collections.Generic;
using System.Linq;

namespace Algostruct.Algorithms.Sort
{
    public class BubbleSort<T> where T : IComparable<T>
    {
        public static IEnumerable<T> Sort(IEnumerable<T> elements)
        {
            var array = elements.ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                bool isSwapped = false;

                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                        isSwapped = true;
                    }
                }

                if (!isSwapped)
                    break;
            }

            return array;
        }
    }
}
