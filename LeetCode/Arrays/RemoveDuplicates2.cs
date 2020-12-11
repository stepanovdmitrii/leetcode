using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Arrays
{
    public class RemoveDuplicates2Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            if(nums.Length < 3)
            {
                return nums.Length;
            }

            int left = 0;
            

            for(int current = 3; current < nums.Length; ++current)
            {
                var window = nums.AsSpan(left, 3);
                if (false == IsValid(window))
                {
                    Swap(ref nums[left + 2], ref nums[current]);
                }
                if (IsValid(window))
                {
                    ++left;
                }
            }

            if(IsValid(nums.AsSpan(left, 3)))
            {
                return left + 3;
            }
            return left + 2;
        }

        private static bool IsValid(Span<int> window)
        {
            return !(window[0] == window[1] && window[1] == window[2]) &&
                   window[1] >= window[0] && window[2] >= window[1];
        }

        private static void Swap(ref int left, ref int right)
        {
            int tmp = left;
            left = right;
            right = tmp;
        }
    }
}
