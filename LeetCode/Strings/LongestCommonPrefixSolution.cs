using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Strings
{
    public class LongestCommonPrefixSolution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            string result = string.Empty;
            if (strs.Length == 0) return result;
            int index = 0;
            bool found = false;
            while (!found)
            {
                for(int str = 0; str < strs.Length; ++str)
                {
                    if(index == strs[str].Length)
                    {
                        found = true;
                        break;
                    }
                    if(strs[str][index] != strs[0][index])
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    result = result + strs[0][index];
                }
                ++index;
            }

            return result;
        }
    }
}
