using System.Collections.Generic;

namespace Algostruct.Questions.LeetCode
{

    public class RomanToInteger
    {
        public static int RomanToInt(string s)
        {
            Dictionary<char, int> romanToInt = new()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (i == s.Length - 1 || romanToInt[s[i]] >= romanToInt[s[i + 1]])
                    result += romanToInt[s[i]];
                else
                {
                    result += romanToInt[s[i + 1]] - romanToInt[s[i]];
                    i++;
                }
            }

            return result;
        }

        public static int PreviousRomanToInt(string s)
        {
            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                char symbol = s[i];

                switch (symbol)
                {
                    case 'I':
                        result += 1;
                        break;
                    case 'V':
                        if (i - 1 >= 0 && s[i - 1] == 'I')
                            result += 4 - 1;
                        else
                            result += 5;
                        break;
                    case 'X':
                        if (i - 1 >= 0 && s[i - 1] == 'I')
                            result += 9 - 1;
                        else
                            result += 10;
                        break;
                    case 'L':
                        if (i - 1 >= 0 && s[i - 1] == 'X')
                            result += 40 - 10;
                        else
                            result += 50;
                        break;
                    case 'C':
                        if (i - 1 >= 0 && s[i - 1] == 'X')
                            result += 90 - 10;
                        else
                            result += 100;
                        break;
                    case 'D':
                        if (i - 1 >= 0 && s[i - 1] == 'C')
                            result += 400 - 100;
                        else
                            result += 500;
                        break;
                    case 'M':
                        if (i - 1 >= 0 && s[i - 1] == 'C')
                            result += 900 - 100;
                        else
                            result += 1000;
                        break;
                    default:
                        return -1;
                }
            }

            return result;
        }
    }
}
