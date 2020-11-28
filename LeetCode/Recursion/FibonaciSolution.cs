using System.Collections.Generic;

namespace LeetCode.Recursion
{
    class FibonaciSolution
    {
        private readonly Dictionary<int, int> _cache = new Dictionary<int, int>();
        public int Fib(int N)
        {
            if (N == 0) return 0;
            if (N == 1) return 1;

            if (_cache.TryGetValue(N, out int value)) return value;

            int val = Fib(N - 1) + Fib(N - 2);
            _cache[N] = val;

            return val;
        }
    }
}
