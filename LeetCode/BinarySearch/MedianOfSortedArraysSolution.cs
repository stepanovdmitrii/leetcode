using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.BinarySearch
{
    class MedianOfSortedArraysSolution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            return FindMedian(MergeSorted(nums1, nums2), nums1.Length + nums2.Length);
        }

        private double FindMedian(IEnumerable<int> nums, int count)
        {
            if(count % 2 == 1)
            {
                int target = count / 2;
                int current = 0;
                foreach(var num in nums)
                {
                    if(current == target)
                    {
                        return num;
                    }
                    ++current;
                }
            }
            else
            {
                int target1 = count / 2 - 1;
                int target2 = count / 2;
                double result = 0;
                int current = 0;
                foreach (var num in nums)
                {
                    if (current == target1)
                    {
                        result = num;
                    }
                    if(current == target2)
                    {
                        return (result + num) / 2;
                    }
                    ++current;
                }
            }

            return -1.0;
        }

        private IEnumerable<int> MergeSorted(int[] num1, int[] num2)
        {
            for(int idx1 = 0, idx2 = 0; idx1 < num1.Length || idx2 < num2.Length;)
            {
                if(idx1 == num1.Length)
                {
                    yield return num2[idx2];
                    ++idx2;
                }
                else if (idx2 == num2.Length)
                {
                    yield return num1[idx1];
                    ++idx1;
                }
                else if (num1[idx1] < num2[idx2])
                {
                    yield return num1[idx1];
                    ++idx1;
                }
                else
                {
                    yield return num2[idx2];
                    ++idx2;
                }
            }
        }
    }
}
