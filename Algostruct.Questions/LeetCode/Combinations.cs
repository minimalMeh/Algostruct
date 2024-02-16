using System.Collections.Generic;

namespace Algostruct.Questions.LeetCode
{
    // Given two integers n and k, return all possible combinations of k numbers chosen from the range [1, n].
    // Input: n = 4, k = 2
    // Output: [[1,2],[1,3],[1,4],[2,3],[2,4],[3,4]]
    public class Combinations
    {
        public static IList<IList<int>> Combine(int n, int k)
        {
            List<IList<int>> result = new();

            Differentiate(k, 1, new());

            return result;

            void Differentiate(int elementsNeedForCombination, int startFromElement, List<int> parentSubCombination)
            {
                if (elementsNeedForCombination == 0)
                {
                    result.Add(parentSubCombination);
                    return;
                }

                for (int i = startFromElement; i <= n; i++)
                {
                    //List<int> childSubCombination = new List<int>(parentSubCombination);
                    //childSubCombination.Add(i);

                    List<int> childSubCombination = new(parentSubCombination) { i };

                    Differentiate(elementsNeedForCombination - 1, i + 1, childSubCombination);
                    //System.Console.WriteLine("Deep: " + parentSubCombination.Count + ' ' + i);
                }
            }
        }
    }
}
