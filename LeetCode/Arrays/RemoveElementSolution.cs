using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Arrays
{
    class RemoveElementSolution
    {
        public int RemoveElement(int[] nums, int val)
        {
            int slow = 0;
            for(int fast = 0; fast < nums.Length; ++fast)
            {
                if(nums[fast] == val)
                {
                    continue;
                }
                nums[slow] = nums[fast];
                ++slow;
            }
            return slow;
        }
    }
}
