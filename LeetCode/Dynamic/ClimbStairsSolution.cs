using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Dynamic
{
    class ClimbStairsSolution
    {
        private Dictionary<int, int> Steps = new Dictionary<int, int>();
        public int ClimbStairs(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 2;
            if (false == Steps.TryGetValue(n, out int result))
            {
                result = ClimbStairs(n - 1) + ClimbStairs(n - 2);
                Steps[n] = result;
            }
            return result;
        }
    }
}
