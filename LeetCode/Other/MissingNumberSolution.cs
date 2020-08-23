using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Other
{
    class MissingNumberSolution
    {
        public int MissingNumber(int[] nums)
        {
            int expected = nums.Length * (nums.Length + 1) / 2;
            foreach(int num in nums)
            {
                expected -= num;
            }
            return expected;
        }
    }
}
