using System;
using System.Linq;

namespace Algostruct.Questions.Other
{
    public class ReverseWordsOrder
    {
        public void Present()
        {
            string s1 = "My name is X Y Z";

            Console.WriteLine(LinqOption(s1));

            string result = "";
            string sub = "";

            for (int i = 0; i <= s1.Length; i++)
            {
                if (i == s1.Length || s1[i] == ' ')
                {
                    result = sub + (result == "" ? result : " " + result);
                    sub = "";
                }
                else
                {
                    sub += s1[i];
                }
            }

            Console.WriteLine(result);
        }

        private static string LinqOption(string s) => string.Join(" ", s.Split(' ').Reverse());
    }
}
