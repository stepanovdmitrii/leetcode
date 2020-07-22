using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Arrays
{
    class SingleNumberArg
    {
        public int SingleNumber(int[] nums)
        {
            int result = 0;
            foreach(var num in nums)
            {
                result ^= num;
            }
            return result;
        }
    }
}
