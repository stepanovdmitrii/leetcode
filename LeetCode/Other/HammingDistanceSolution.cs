using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Other
{
    public class HammingDistanceSolution
    {
        public int HammingDistance(int x, int y)
        {
            int result = 0;
            int xor = x ^ y;
            for(int i = 0; i < 32; ++i)
            {
                result += (xor & 1);
                xor = xor >> 1;
            }
            return result;
        }
    }
}
