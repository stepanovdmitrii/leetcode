using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Arrays
{
    class IntersectionOfTwoArrays2
    {
        public int[] Intersect2(int[] nums1, int[] nums2)
        {
            Array.Sort(nums1);
            Array.Sort(nums2);
            var result = new List<int>();

            for(int i1 = 0, i2 = 0; i1 < nums1.Length && i2 < nums2.Length;)
            {
                if(nums1[i1] == nums2[i2])
                {
                    result.Add(nums1[i1]);
                    ++i1;
                    ++i2;
                }
                else if(nums1[i1] < nums2[i2])
                {
                    ++i1;
                }
                else
                {
                    ++i2;
                }
            }

            return result.ToArray();
        }

        public int[] Intersection(int[] nums1, int[] nums2)
        {
            Array.Sort(nums1);
            Array.Sort(nums2);
            var result = new List<int>();

            for (int i1 = 0, i2 = 0; i1 < nums1.Length && i2 < nums2.Length;)
            {
                if (nums1[i1] == nums2[i2])
                {
                    if (result.Count == 0 || result[result.Count - 1] != nums1[i1])
                    {
                        result.Add(nums1[i1]);
                    }
                    ++i1;
                    ++i2;
                }
                else if (nums1[i1] < nums2[i2])
                {
                    ++i1;
                }
                else
                {
                    ++i2;
                }
            }

            return result.ToArray();
        }
    }
}
