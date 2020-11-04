using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.BinarySearch
{
    class RotatedSortedArrayMinimum
    {
        public int FindMin(int[] nums)
        {
            if (nums.Length == 1) return nums[0];
            int pivot = FindPivot(nums);
            return nums[0] < nums[pivot] ? nums[0] : nums[pivot];
        }

        private int FindPivot(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] > nums[left])
                {
                    left = mid;
                }
                else
                {
                    right = mid;
                }
            }
            return left + 1;
        }
    }
}
