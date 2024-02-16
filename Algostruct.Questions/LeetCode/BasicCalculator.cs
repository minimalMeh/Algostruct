using System.Collections.Generic;

namespace Algostruct.Questions.LeetCode
{
    public class BasicCalculator
    {
        public static int Calculate(string s)
        {
            Stack<int> stack = new();

            int currentNumberProcessing = 0;
            int expressionResult = 0;
            int sign = 1;

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];

                if (char.IsNumber(c))
                {
                    currentNumberProcessing = (int)char.GetNumericValue(c);

                    int j = i;

                    while (j != s.Length - 1 && char.IsNumber(s[j + 1]))
                    {
                        currentNumberProcessing = currentNumberProcessing * 10 + (int)char.GetNumericValue(s[j + 1]);
                        i = ++j;
                    }
                }
                else if (c == '+' || c == '-')
                {
                    expressionResult += sign * currentNumberProcessing;
                    sign = c == '+' ? 1 : -1;
                }
                else if (c == '(')
                {
                    stack.Push(expressionResult);
                    stack.Push(sign);

                    expressionResult = 0;
                    sign = 1;
                    currentNumberProcessing = 0;
                }
                else if (c == ')')
                {
                    expressionResult += sign * currentNumberProcessing;

                    var signOfOperationBeforeBraces = stack.Pop();
                    var expressionResultOfOperationBeforeBraces = stack.Pop();
                    expressionResult *= signOfOperationBeforeBraces; //stack.Pop();
                    expressionResult += expressionResultOfOperationBeforeBraces; // stack.Pop();

                    currentNumberProcessing = 0;
                }
            }

            return expressionResult + sign * currentNumberProcessing;
        }
    }
}
