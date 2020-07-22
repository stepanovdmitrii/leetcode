namespace LeetCode
{
    public sealed class BestTimeToBuyAndSell2
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length <= 1) return 0;
            int profit = 0;
            int current = 0;
            for(int next = current + 1; next < prices.Length; ++next)
            {
                if (prices[next] > prices[current])
                {
                    profit += prices[next] - prices[current];
                }
                current = next;
            }
            return profit;
        }
    }
}
