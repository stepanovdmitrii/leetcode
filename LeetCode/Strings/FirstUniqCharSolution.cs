using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Strings
{
    class FirstUniqCharSolution
    {
        public int FirstUniqChar(string s)
        {
            if (string.IsNullOrEmpty(s)) return -1;

            var unique = new Dictionary<char, int>();
            var nonUnique = new HashSet<char>();
            for(int index = 0; index < s.Length; ++index)
            {
                char ch = s[index];

                if (nonUnique.Contains(ch)) continue;

                if (unique.ContainsKey(ch))
                {
                    unique.Remove(ch);
                    nonUnique.Add(ch);
                }
                else
                {
                    unique.Add(ch, index);
                }
            }
            if (unique.Count == 0) return -1;
            return unique.Min(p => p.Value);
        }
    }
}
