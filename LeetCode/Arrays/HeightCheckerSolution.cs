using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Arrays
{
    class HeightCheckerSolution
    {
        public int HeightChecker(int[] heights)
        {
            var sorted = new int[heights.Length];
            Array.Copy(heights, sorted, heights.Length);
            Array.Sort(sorted);
            int result = 0;
            for(int i = 0; i < sorted.Length; ++i)
            {
                if(sorted[i] != heights[i])
                {
                    ++result;
                }
            }
            return result;
        }
    }
}
