using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Math
{
    class PowerOfThreeSolution
    {
        private const int MaxPowerOfThreeInt32 = 1162261467;
        public bool IsPowerOfThree(int n)
        {
            return n > 0 && MaxPowerOfThreeInt32 % n == 0;
        }
    }
}
