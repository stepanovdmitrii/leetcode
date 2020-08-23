using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Other
{
    class HammingWeightSolution
    {
        public int HammingWeight(uint n)
        {
            int result = 0;
            uint powerOfTwo = 1;
            for(int i = 0; i < 32; ++i)
            {
                if((n & powerOfTwo) == powerOfTwo)
                {
                    ++result;
                }
                powerOfTwo = powerOfTwo * 2;
            }
            return result;
        }
    }
}
