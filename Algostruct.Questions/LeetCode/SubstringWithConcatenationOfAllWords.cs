using System.Collections.Generic;
using System.Linq;

namespace Algostruct.Questions.LeetCode
{
    // You are given a string s and an array of strings words.All the strings of words are of the same length.
    // A concatenated substring in s is a substring that contains all the strings of any permutation of words concatenated.

    // For example, if words = ["ab", "cd", "ef"], then "abcdef", "abefcd", "cdabef", "cdefab", "efabcd",
    // and "efcdab" are all concatenated strings. "acdbef" is not a concatenated substring because it is
    // not the concatenation of any permutation of words.

    // Return the starting indices of all the concatenated substrings in s.You can return the answer in any order.
    public class SubstringWithConcatenationOfAllWords
    {
        public static IList<int> FindSubstring(string s, string[] words)
        {
            var result = new List<int>();

            if (s.Length == 0 || words.Length == 0 || s.Length < words.Sum(w => w.Length))
                return result;

            int wordsCount = words.Length;
            int singleWordLength = words[0].Length;

            Dictionary<string, int> wordsToCount = new();

            foreach (string word in words)
            {
                if (wordsToCount.TryGetValue(word, out int value))
                    wordsToCount[word] = ++value;
                else
                    wordsToCount.Add(word, 1);
            }

            int lengthOfWordsCombined = wordsCount * singleWordLength;
            int enoughLengthInStringToCheck = s.Length - lengthOfWordsCombined + 1;

            for (int i = 0; i < enoughLengthInStringToCheck; i++)
            {
                Dictionary<string, int> seen = new();
                int j;

                for (j = 0; j < wordsCount; j++)
                {
                    int startIndexOfThePossibleWord = i + j * singleWordLength;
                    string word = s.Substring(startIndexOfThePossibleWord, singleWordLength);

                    if (seen.TryGetValue(word, out int seenCount))
                        seen[word] = ++seenCount;
                    else
                        seen[word] = 1;

                    int requiredCountOfCurrentWord = wordsToCount.GetValueOrDefault(word, 0);

                    if (seen[word] > requiredCountOfCurrentWord)
                        break;
                }

                if (j == wordsCount)
                    result.Add(i);
            }

            return result;
        }
    }
}
