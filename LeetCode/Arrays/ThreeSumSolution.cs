using System;
using System.Collections.Generic;

namespace LeetCode.Arrays
{
    class ThreeSumSolution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var result = new List<IList<int>>();
            Array.Sort(nums);
            for(int idx = 0; idx < nums.Length - 2 && nums[idx] <= 0; ++idx)
            {
                if (nums[idx] > 0) break;
                if (idx != 0 && nums[idx] == nums[idx - 1]) continue;

                int left = idx + 1;
                int right = nums.Length - 1;

                while(left < right)
                {
                    int sum = (-1) * (nums[left] + nums[right]);
                    if(sum == nums[idx])
                    {
                        var arr = new List<int> { nums[idx], nums[left], nums[right] };
                        result.Add(arr);

                        do
                        {
                            ++left;
                        }
                        while (left < right && nums[left] == nums[left - 1]);
                        do
                        {
                            --right;
                        }
                        while (left < right && nums[right] == nums[right + 1]);
                    }
                    else if(sum > nums[idx])
                    {
                        do
                        {
                            ++left;
                        }
                        while (left < right && nums[left] == nums[left - 1]);
                    }
                    else
                    {
                        do
                        {
                            --right;
                        }
                        while (left < right && nums[right] == nums[right + 1]);
                    }
                }
            }

            return result;
        }
    }
}
