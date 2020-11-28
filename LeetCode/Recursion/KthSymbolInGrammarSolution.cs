namespace LeetCode.Recursion
{
    class KthSymbolInGrammarSolution
    {
        public int KthGrammar(int N, int K)
        {
            return Internal(N, K - 1);
        }

        private int Internal(int N, int K)
        {
            if (N == 1) return 0;

            if (K == 0) return 0;
            if (K == 1) return 1;

            int prev = Internal(N - 1, K / 2);

            if (prev == 0)
            {
                return K % 2 == 0 ? 0 : 1;
            }
            else
            {
                return K % 2 == 0 ? 1 : 0;
            }
        }
    }
}
