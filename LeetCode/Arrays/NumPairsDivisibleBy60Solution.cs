using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Arrays
{
    public class NumPairsDivisibleBy60Solution
    {
        public int NumPairsDivisibleBy60(int[] time)
        {
            int result = 0;
            var mods = new int[60];
            for (int idx = 0; idx < time.Length; ++idx)
            {
                int modulo = time[idx] % 60;
                int opp = modulo == 0 ? 0 : 60 - modulo;
                result += mods[opp];

                mods[modulo]++;
            }

            return result;
        }
    }
}
