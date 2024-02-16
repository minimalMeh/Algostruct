using System;
using System.Collections.Generic;
using System.Linq;

namespace Algostruct.Algorithms.Search
{
    public class BinarySearch<T> where T : IComparable<T>
    {
        public bool IsValueExist(IEnumerable<T> collection, T value)
        {
            T[] collectionArray = collection.ToArray();

            int minIndex = 0;
            int maxIndex = collectionArray.Length;

            while (minIndex < maxIndex)
            {
                int midIndex = (minIndex + maxIndex) / 2;

                int compareResult = collectionArray[midIndex].CompareTo(value);

                if (compareResult == 0)
                    return true;

                if (compareResult > 0)
                    maxIndex = midIndex;
                else
                    minIndex = midIndex + 1;
            }

            return false;
        }
    }
}
