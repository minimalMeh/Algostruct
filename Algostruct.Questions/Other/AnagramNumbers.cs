using System.Collections.Generic;
using System.Linq;

namespace Algostruct.Questions.Other
{
    public class AnagramNumbers
    {
        public static int GetAnagrams(string s)
        {
            if (s.Length % 2 != 0)
                return -1;

            int halfLength = s.Length / 2;

            string firstPart = new(s.Take(halfLength).ToArray());
            string secondPart = new(s.Skip(firstPart.Length).ToArray());

            Dictionary<int, int> numberCount = new();

            for (int i = 0; i < halfLength; i++)
            {
                int number = (int)char.GetNumericValue(firstPart[i]);

                if (numberCount.TryGetValue(number, out int count))
                {
                    numberCount[number] = ++count;
                }

                numberCount.TryAdd(number, 1);
            }

            for (int i = 0; i < halfLength; i++)
            {
                int number = (int)char.GetNumericValue(secondPart[i]);

                if (numberCount.TryGetValue(number, out int count))
                {
                    numberCount[number] = --count;
                }
            }

            return numberCount.Where(kv => kv.Value > 0).Count();
        }
    }
}
