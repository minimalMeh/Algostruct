using System;
using System.Collections.Generic;
using System.Linq;

namespace Algostruct.Questions.CodeSignal
{
    // Write a function that reverses characters in (possibly nested) parentheses in the input string.
    // For inputString = "foo(bar)baz(blim)", the output should be
    // solution(inputString) = "foorabbazmilb";
    // For inputString = "foo(bar(baz))blim", the output should be
    // solution(inputString) = "foobazrabblim".
    // Because "foo(bar(baz))blim" becomes "foo(barzab)blim" and then "foobazrabblim".
    public class ReverseInParentheses
    {
        public static string Solution(string inputString)
        {
            Stack<int> openIndexes = new();

            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == '(')
                    openIndexes.Push(i);

                if (inputString[i] == ')')
                {
                    int startIndex = openIndexes.Pop();
                    int innerLength = i - startIndex + 1;

                    string subString = inputString.Substring(startIndex, innerLength);
                    string reversed = new(subString.Reverse().ToArray());

                    inputString = inputString
                        .Remove(startIndex, innerLength)
                        .Insert(startIndex, reversed);
                }
            }

            return inputString.Replace("(", "").Replace(")", "");
        }
    }
}
