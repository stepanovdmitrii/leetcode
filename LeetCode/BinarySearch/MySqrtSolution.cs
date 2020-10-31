using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.BinarySearch
{
    public class MySqrtSolution
    {
        public int MySqrt(int x)
        {
            int left = 0;
            int right = x;
            int val = -1;

            while(left <= right)
            {
                int mid = left + (right - left) / 2;

                if(mid != 0 && mid > (int.MaxValue / mid))
                {
                    right = mid - 1;
                    continue;
                }

                val = mid * mid;

                if (val == x) return mid;

                if (val > x) right = mid - 1;
                else left = mid + 1;
            }

            return right;
        }
    }
}
