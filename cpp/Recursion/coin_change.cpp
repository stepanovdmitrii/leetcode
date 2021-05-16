#include <vector>
#include <algorithm>

using namespace std;

class Solution
{
public:
    int coinChange(vector<int> &coins, int amount)
    {
        vector<int> d(amount + 1);
        d[0] = 0;
        for (size_t idx = 1; idx <= amount; ++idx)
        {
            d[idx] = 10001;
            for (size_t coin_idx = 0; coin_idx < coins.size(); ++coin_idx)
            {
                if (idx >= coins[coin_idx])
                {
                    d[idx] = min(d[idx], d[idx - coins[coin_idx]] + 1);
                }
            }
        }

        if(d[amount] == 10001){
            return -1;
        }
        return d[amount];
    }
};