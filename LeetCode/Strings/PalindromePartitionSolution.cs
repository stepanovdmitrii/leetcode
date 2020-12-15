using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Strings
{
    class PalindromePartitionSolution
    {
        public IList<IList<string>> Partition(string s)
        {
            var result = new List<IList<string>>();
            Partition(0, result, new List<string>(), s);
            return result;
        }

        private static void Partition(int start, IList<IList<string>> result, List<string> buffer, string source)
        {
            if (start >= source.Length) result.Add(new List<string>(buffer));
            for(int end = start; end < source.Length; ++end)
            {
                if(IsPalindrome(source, start, end))
                {
                    buffer.Add(source.Substring(start, end - start + 1));
                    Partition(end, result, buffer, source);
                    buffer.RemoveAt(buffer.Count - 1);
                }
            }
        }

        private static bool IsPalindrome(string s, int low, int high)
        {
            while (low < high)
            {
                if (s[low++] != s[high--]) return false;
            }
            return true;
        }
    }
}
