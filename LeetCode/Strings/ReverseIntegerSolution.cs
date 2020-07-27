using System;
using System.Text;

namespace LeetCode.Strings
{
    public class ReverseIntegerSolution
    {
        public int Reverse(int x)
        {
            if (x == 0) return x;
            int result = 0;
            while(x != 0)
            {
                int app = x % 10;
                if (result > int.MaxValue / 10) return 0;
                if (result < int.MinValue / 10) return 0;
                if (result == int.MaxValue / 10 && (app > 7 || app < -8)) return 0;
                result *= 10;
                result += app;
                x /= 10;
            }
            return result;
        }
    }
}
