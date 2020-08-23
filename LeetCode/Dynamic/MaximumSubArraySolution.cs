using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Dynamic
{
    class MaximumSubArraySolution
    {
        public int MaxSubArray(int[] nums)
        {
            int result = Int32.MinValue;
            int current = 0;
            for(int index = 0; index < nums.Length; ++index)
            {
                if (index != 0) {
                    current = System.Math.Max(nums[index], current + nums[index]);
                }
                else
                {
                    current = nums[index];
                }
                result = System.Math.Max(result, current);
            }
            return result;
        }
    }
}
