using Algostruct.Core.Interfaces;
using System;
using System.Linq;

namespace Algostruct.Questions.Other
{
    public class ReverseWordsOrder : IDescribable, IPresentable
    {
        public string Name => "Reverse the order of the words";
        public string Description => "s1 = \"My name is X Y Z\" to s1 = \"Z Y X is name My\"";

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

        private string LinqOption(string s) => string.Join(" ", s.Split(' ').Reverse());

        //static char[] ReverseAllWords(char[] in_text)
        //{
        //    int lindex = 0;
        //    int rindex = in_text.Length - 1;
        //    if (rindex > 1)
        //    {
        //        //reverse complete phrase
        //        in_text = ReverseString(in_text, 0, rindex);

        //        //reverse each word in resultant reversed phrase
        //        for (rindex = 0; rindex <= in_text.Length; rindex++)
        //        {
        //            if (rindex == in_text.Length || in_text[rindex] == ' ')
        //            {
        //                in_text = ReverseString(in_text, lindex, rindex - 1);
        //                lindex = rindex + 1;
        //            }
        //        }
        //    }
        //    return in_text;
        //}

        //static char[] ReverseString(char[] intext, int lindex, int rindex)
        //{
        //    char tempc;
        //    while (lindex < rindex)
        //    {
        //        tempc = intext[lindex];
        //        intext[lindex++] = intext[rindex];
        //        intext[rindex--] = tempc;
        //    }
        //    return intext;
        //}
    }
}
