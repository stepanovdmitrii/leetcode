using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Arrays
{
    class ThirdMaxNumberSolution
    {
        public int ThirdMax(int[] nums)
        {
            if (nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];

            Array.Sort(nums);
            int result = nums[nums.Length - 1];
            int max = result;
            int left = 2;
            for(int i = nums.Length - 2; i >=0; --i)
            {
                if(nums[i] < result)
                {
                    result = nums[i];
                    --left;
                }
                if (left == 0) return result;
            }
            return max;
        }
    }
}
