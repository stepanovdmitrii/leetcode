using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Arrays
{
    class MaxConsecutiveOnesSolution
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int result = 0;
            int current = 0;
            for(int i = 0; i < nums.Length; ++i)
            {
                if(nums[i] == 1)
                {
                    current++;
                }
                else
                {
                    result = current > result ? current : result;
                    current = 0;
                }
            }
            result = current > result ? current : result;
            return result;
        }
    }
}
