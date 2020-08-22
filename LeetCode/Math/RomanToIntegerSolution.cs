using System.Collections.Generic;

namespace LeetCode.Math
{
    class RomanToIntegerSolution
    {
        private static Dictionary<string, int> Doubled = new Dictionary<string, int>
        {
            { "IV", 4 },
            { "IX", 9 },
            { "XL", 40 },
            { "XC", 90 },
            { "CD", 400},
            { "CM", 900 }
        };

        private static Dictionary<char, int> Single = new Dictionary<char, int>
        {
            {'I', 1 },
            {'V', 5},
            {'X', 10 },
            {'L', 50 },
            {'C', 100 },
            {'D', 500 },
            {'M', 1000 }
        };

        public int RomanToInt(string s)
        {
            int result = 0;
            for(int i = 0; i < s.Length;)
            {
                if(s.Length - i > 1 && Doubled.TryGetValue(s.Substring(i, 2), out int value))
                {
                    result += value;
                    i = i + 2;
                }
                else
                {
                    result += Single[s[i]];
                    ++i;
                }
            }
            return result;
        }
    }
}
