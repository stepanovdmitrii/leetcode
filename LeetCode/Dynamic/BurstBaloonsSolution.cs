using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Dynamic
{
    class BurstBaloonsSolution
    {
        public int MaxCoins(int[] nums)
        {
            var buffer = new int[nums.Length + 2];
            buffer[0] = buffer[buffer.Length - 1] = 1;
            for(int i = 0; i < nums.Length; ++i)
            {
                buffer[i + 1] = nums[i];
            }
            var dp = new int[buffer.Length][];
            for(int i = 0; i < dp.Length; ++i)
            {
                dp[i] = new int[buffer.Length];
            }

            for(int lenght = 1; lenght < buffer.Length - 1; ++lenght)
            {
                for(int left = 0; left < buffer.Length - 1 - lenght; ++left)
                {
                    int right = left + lenght + 1;
                    for(int last = left + 1; last < right; ++last)
                    {
                        dp[left][right] = System.Math.Max(dp[left][right],
                                          buffer[left] * buffer[last] * buffer[right] +
                                          dp[left][last] + dp[last][right]);
                    }

                }
            }
            return dp[0][buffer.Length - 1];
        }
    }
}
