using System.Collections.Generic;

namespace Algostruct.Questions.LeetCode
{
    // Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    // Input: nums = [3,2,4], target = 6
    // Output: [1,2]
    public class TwoSum
    {
        public static int[] FindSum(int[] nums, int target)
        {
            Dictionary<int, int> numberIndex = new();

            for (int i = 0; i < nums.Length; i++)
            {
                if (numberIndex.ContainsKey(target - nums[i]))
                    return new int[] { numberIndex[target - nums[i]], i };

                numberIndex.TryAdd(nums[i], i);
            }

            return default;
        }
    }
}
