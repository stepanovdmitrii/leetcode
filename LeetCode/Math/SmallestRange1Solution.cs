using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Math
{
    class SmallestRange1Solution
    {
        public int SmallestRangeI(int[] A, int K)
        {
            Array.Sort(A);
            int min = A[0];
            int max = A[A.Length - 1];
            int result = max - min - 2 * K;
            if (result > 0) return result;
            return 0;
        }
    }
}
