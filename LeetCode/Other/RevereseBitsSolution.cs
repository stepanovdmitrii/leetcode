using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Other
{
    class RevereseBitsSolution
    {
        public uint reverseBits(uint n)
        {
            uint result = 0;
            for(int i = 0; i < 32; ++i)
            {
                result = result << 1;
                if ((n & 1) == 1)
                {
                    result += 1;
                }
                n = n >> 1;
            }
            return result;
        }
    }
}
