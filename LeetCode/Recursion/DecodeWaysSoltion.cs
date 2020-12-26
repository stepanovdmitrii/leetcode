using System;
using System.Collections.Generic;

namespace LeetCode.Recursion
{
    public sealed class DecodeWaysSoltion
    {
        private int _count = 0;

        public int NumDecodings(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            return DecodeInternal(s, new Dictionary<string, int>());
        }

        private int DecodeInternal(string str, Dictionary<string, int> cache)
        {
            if(str.Length == 0)
            {
                return 1;
            }

            if (str[0] == '0')
            {
                return 0;
            }

            if(cache.TryGetValue(str, out var value))
            {
                return value;
            }

            int count = DecodeInternal(str.Substring(1), cache);

            if (str.Length > 1)
            {
                int twoCharValue = 10 * int.Parse(str[0].ToString()) + int.Parse(str[1].ToString());
                if (twoCharValue <= 26)
                {
                    int secondCount = DecodeInternal(str.Substring(2), cache);
                    count += secondCount;
                }
            }

            cache[str] = count;

            return count;
        }
    }
}
