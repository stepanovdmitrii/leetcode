#include <vector>
#include <iostream>

using namespace std;

class Solution {
public:
    int uniquePaths(int m, int n) {
        vector<vector<int>> dp(m, vector<int>(n, 0));
        dp[0][0] = 1;
        for(int column = 0; column < n; ++column) {
            for(int row = 0; row < m; ++row) {
                if(row == 0 && column == 0) {
                    continue;
                }

                int upper = 0;
                if(row > 0) {
                    upper = dp[row - 1][column];
                }
                int left = 0;
                if(column > 0) {
                    left = dp[row][column - 1];
                }
                dp[row][column] = upper + left;
            }
        }
        return dp[m-1][n-1];
    }
};

int main() {
    Solution s;
    cout << s.uniquePaths(3, 7);
}