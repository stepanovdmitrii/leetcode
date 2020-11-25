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

        public int FindMin2(int[] nums)
        {
            return FindMin2(nums, 0, nums.Length - 1);
        }

        private int FindMin2(int[] nums, int left, int right)
        {
            while (left <= right)
            {
                while(left != right && nums[left] == nums[right])
                {
                    ++left;
                }

                if(nums[left] <= nums[right])
                {
                    return nums[left];
                }

                int mid = left + (right - left) / 2;

                if (mid < nums.Length - 1 && nums[mid] > nums[mid + 1])
                {
                    return nums[mid + 1];
                }

                if (nums[mid] >= nums[left])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }

            }
            return nums[0];
        }
    }
}
