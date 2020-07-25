using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Arrays
{
    class TwoSumSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();
            for(int index = 0; index < nums.Length; ++index)
            {
                int sub = target - nums[index];
                if(dict.TryGetValue(sub, out int second))
                {
                    return new[] { second, index };
                }
                dict[nums[index]] = index;
            }
            throw new Exception();
        }
    }
}
