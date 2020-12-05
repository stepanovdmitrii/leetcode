namespace LeetCode.Other
{
    class KthFactorSolution
    {
        public int KthFactor(int n, int k)
        {
            int index = 0;
            for(int i = 1; i <= n; ++i)
            {
                if (n % i == 0) ++index;
                if (index == k) return index;
            }
            return index == k ? index : -1;
        }
    }
}
