using Algostruct.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Algostruct.Questions.Other
{
    public class AnagramStrings : IDescribable, IPresentable
    {
        public string Name => "How to check if two Strings (words) are Anagrams?";
        public string Description => "An anagram is a word or phrase that's formed by rearranging the letters of another word or phrase. ";

        public void Present()
        {
            string first = "2ureto";
            string second = "outer1";

            bool areAnagrams = AreAnagrams(first, second);

            Console.WriteLine(areAnagrams);
        }

        private static bool AreAnagrams(string first, string second)
        {
            Dictionary<char, int> chars = new();

            foreach (char ch in first)
            {
                if (!chars.ContainsKey(ch))
                    chars[ch] = 0;

                chars[ch]++;
            }

            foreach (char ch in second)
            {
                if (!chars.TryGetValue(ch, out int value))
                    return false;

                chars[ch] = --value;
            }

            return chars.All(ch => ch.Value == 0);
        }
    }
}

