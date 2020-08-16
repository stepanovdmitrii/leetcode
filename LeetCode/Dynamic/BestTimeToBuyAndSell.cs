using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Dynamic
{
    class BestTimeToBuyAndSell
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length <= 1) return 0;
            int profit = 0;
            int min = Int32.MaxValue;
            for (int index = 0; index < prices.Length; ++index)
            {
                if(prices[index] < min)
                {
                    min = prices[index];
                }
                else if (profit < prices[index] - min)
                {
                    profit = prices[index] - min;
                }
            }
            return profit;
        }
    }
}
