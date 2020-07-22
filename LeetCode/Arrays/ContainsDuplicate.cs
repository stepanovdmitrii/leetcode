using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Arrays
{
    public sealed class ContainsDuplicateAlg
    {
        public bool ContainsDuplicate(int[] nums)
        {
            if (nums.Length <= 1) return false;
            var set = new HashSet<int>();

            for(int i = 0; i < nums.Length; ++i)
            {
                if (set.Add(nums[i]) == false) return true;
            }
            return false;
        }
    }
}
