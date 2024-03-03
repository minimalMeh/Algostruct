using System;
using System.Linq;

namespace Algostruct.Algorithms.Sort
{
    public class MergeSort
    {
        public static int[] Sort(int[] elements)
        {
            MergeSorting(elements);
            return elements;
        }

        static void MergeSorting(int[] elements)
        {
            if (elements.Length <= 1)
                return;

            if (elements.Length == 2 && elements[0] > elements[1])
            {
                (elements[0], elements[1]) = (elements[1], elements[0]);
                return;
            }

            //if (elements.Length < 10)
            //    new SelectionSort<int>().Sort(elements);

            int halfSize = elements.Length / 2;

            int[] firstHalf = elements.Take(halfSize).ToArray(); // returns new array
            int[] secondHalf = elements.Skip(halfSize).ToArray(); // returns new array

            MergeSorting(firstHalf);
            MergeSorting(secondHalf);

            MergeSorted(firstHalf, secondHalf, elements);
        }

        static void MergeSorted(int[] first, int[] second, int[] target)
        {
            int firstIndex = 0;
            int secondIndex = 0;
            int targetIndex = 0;

            while (firstIndex < first.Length && secondIndex < second.Length)
            {
                if (first[firstIndex] <= second[secondIndex])
                {
                    target[targetIndex] = first[firstIndex];
                    ++firstIndex;
                }
                else
                {
                    target[targetIndex] = second[secondIndex];
                    ++secondIndex;
                }

                ++targetIndex;
            }

            if (firstIndex < first.Length)
            {
                Array.Copy(first, firstIndex, target, targetIndex, first.Length - firstIndex);
            }
            else if (secondIndex < second.Length)
            {
                Array.Copy(second, secondIndex, target, targetIndex, second.Length - secondIndex);
            }
        }
    }
}
