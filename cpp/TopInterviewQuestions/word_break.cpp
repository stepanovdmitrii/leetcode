#include <vector>
#include <string>
#include <string_view>
#include <algorithm>
#include <unordered_set>

using namespace std;


class Solution {
public:
    bool wordBreak(string s, vector<string>& wordDict) {
        unordered_set<string> ss(wordDict.begin(), wordDict.end());
        size_t max_size = 0;
        for(const string& w: wordDict) {
            if(max_size < w.size()){
                max_size = w.size();
            }
        }

        vector<bool> dp(s.size(), false);
        for(size_t i = 0; i < dp.size(); ++i){
            if(i > 0 && false == dp[i-1]){
                continue;
            }

            string str = "";
            for(size_t j = i; j < s.size() && str.size() <= max_size; ++j) {
                str += s[j];
                if(ss.find(str) != ss.end()){
                    dp[j] = i > 0 ? dp[i-1] : true;
                }
            }
        }

        return dp[dp.size() - 1];
    }
};