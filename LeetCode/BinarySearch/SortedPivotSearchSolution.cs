using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.BinarySearch
{
    public sealed class SortedPivotSearchSolution
    {
        public int Search(int[] nums, int target)
        {
            int pivot = FindPivot(nums);
            int result = Search(nums, 0, pivot, target);
            if (result != -1) return result;
            return Search(nums, pivot, nums.Length - pivot, target);
        }

        private int FindPivot(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            while(left < right)
            {
                int mid = left + (right - left) / 2;
                if(nums[mid] > nums[left])
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

        private int Search(int[] nums, int from, int lenght, int target)
        {
            if (lenght == 0) return -1;
            int left = from;
            int right = from + lenght - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target) return mid;
                if (target < nums[mid]) right = mid - 1;
                else left = mid + 1;
            }

            return -1;
        }
    }
}
