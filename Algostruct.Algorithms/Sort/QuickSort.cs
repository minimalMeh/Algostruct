namespace Algostruct.Algorithms.Sort
{
    public class QuickSort
    {
        public static void Sort(int[] data)
        {
            QuickSortGeneral(data, 0, data.Length - 1);
        }

        public static void QuickSortGeneral(int[] nums, int lowestIndex, int highestIndex)
        {
            int leftIndex = lowestIndex;
            int rightIndex = highestIndex;

            int pivot = nums[(lowestIndex + highestIndex) / 2];

            while (leftIndex <= rightIndex)
            {
                while (nums[leftIndex] < pivot)
                    ++leftIndex;

                while (nums[rightIndex] > pivot)
                    --rightIndex;

                if (leftIndex <= rightIndex)
                {
                    if (leftIndex != rightIndex) // improvement
                        (nums[leftIndex], nums[rightIndex]) = (nums[rightIndex], nums[leftIndex]);

                    ++leftIndex;
                    --rightIndex;
                }
            }

            if (lowestIndex < rightIndex)
                QuickSortGeneral(nums, lowestIndex, rightIndex);

            if (leftIndex < highestIndex)
                QuickSortGeneral(nums, leftIndex, highestIndex);
        }
    }
}
