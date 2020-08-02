using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Strings
{
    class IsPalindromeSolution
    {
        public bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;
            if (s.Length == 1) return true;

            int left = 0;
            int right = s.Length - 1;

            s = s.ToLowerInvariant();

            while(left < right)
            {
                while(left < s.Length && !Char.IsLetterOrDigit(s[left]))
                {
                    ++left;
                }

                while(right >= 0 && !Char.IsLetterOrDigit(s[right]))
                {
                    --right;
                }
                if (left < right && s[left] != s[right]) return false;
                ++left;
                --right;
            }

            return true;

        }
    }
}
