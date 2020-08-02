using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Strings
{
    class StrStrSolution
    {
        public int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle)) return 0;
            if (string.IsNullOrEmpty(haystack)) return -1;
            if (needle.Length > haystack.Length) return -1;


            for(int index = 0; index < haystack.Length; ++index)
            {
                if (haystack[index] != needle[0]) continue;
                if (Contains(haystack, index, needle)) return index;
            }

            return -1;
        }

        private static bool Contains(string haystack, int index, string needle)
        {
            if (needle.Length > haystack.Length - index) return false;
            for(int needleIndex = 0; needleIndex < needle.Length;)
            {
                if (haystack[index] != needle[needleIndex]) return false;
                ++needleIndex;
                ++index;
            }
            return true;
        }
    }
}
