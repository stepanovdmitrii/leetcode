using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Math
{
    class SmallestRange2Solution
    {
        public int SmallestRangeII(int[] A, int K)
        {
            Array.Sort(A);
            int ans = A[A.Length - 1] - A[0];

            for (int i = 0; i < A.Length - 1; ++i)
            {
                int current = A[i];
                int right = A[i + 1];
                int max = System.Math.Max(A[A.Length - 1] - K, current + K);
                int min = System.Math.Min(A[0] + K, right - K);
                ans = System.Math.Min(ans, max - min);
            }
            return ans;
        }
    }
}
