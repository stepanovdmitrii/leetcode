using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.SortingAndSearching
{
    class MergeSortedArraySolution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (n == 0) return;
            if (m == 0)
            {
                for (int i = 0; i < n; ++i)
                {
                    nums1[i] = nums2[i];
                }
                return;
            }

            int target = m + n - 1;
            int index1 = m - 1;
            int index2 = n - 1;

            while (index1 >= 0 || index2 >= 0)
            {
                if(index1 < 0)
                {
                    nums1[target] = nums2[index2];
                    --index2;
                }
                else if (index2 < 0)
                {
                    nums1[target] = nums1[index1];
                    --index1;
                }
                else if(nums2[index2] > nums1[index1])
                {
                    nums1[target] = nums2[index2];
                    --index2;
                }
                else
                {
                    nums1[target] = nums1[index1];
                    --index1;
                }
                --target;
            }
        }
    }
}
