using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Strings
{
    class ValidAnagramSolution
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;

            var map = new Dictionary<char, int>();

            for(int index= 0; index < s.Length; ++index)
            {
                char sChar = s[index];
                char tChar = t[index];

                if (!map.ContainsKey(sChar))
                {
                    map[sChar] = 0;
                }

                if (!map.ContainsKey(tChar))
                {
                    map[tChar] = 0;
                }

                map[sChar]++;
                map[tChar]--;
            }

            foreach(var pair in map)
            {
                if (pair.Value != 0) return false;
            }

            return true;
        }
    }
}
