using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.BinaryTree
{
    class FourSum2Solution
    {
          public int FourSumCount(int[] A, int[] B, int[] C, int[] D)
        {
            var left = new Dictionary<long, int>();

            for (int aIdx = 0; aIdx < A.Length; ++aIdx)
            {
                for (int bIdx = 0; bIdx < B.Length; ++bIdx)
                {
                    long sum = A[aIdx] + B[bIdx];
                    if (left.ContainsKey(sum))
                    {
                        left[sum]++;
                    }
                    else
                    {
                        left[sum] = 1;
                    }
                }
            }

            int count = 0;

            for (int cIdx = 0; cIdx < C.Length; ++cIdx)
            {
                for (int dIdx = 0; dIdx < D.Length; ++dIdx)
                {
                    long sum = 0L - C[cIdx] - D[dIdx];
                    if (left.TryGetValue(sum, out int rightCount))
                    {
                        count += rightCount;
                    }
                }
            }

            return count;
        }
    }
}
