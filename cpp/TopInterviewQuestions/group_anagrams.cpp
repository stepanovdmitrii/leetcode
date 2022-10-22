#include <vector>
#include <string>
#include <unordered_map>
#include <algorithm>
#include <utility>

using namespace std;

class Solution {
public:
    vector<vector<string>> groupAnagrams(vector<string>& strs) {
        vector<vector<string>> result;
        unordered_map<string, vector<string>> groups;

        for(size_t idx = 0; idx < strs.size(); ++idx) {
            string s(strs[idx]);
            sort(s.begin(), s.end());

            groups[s].push_back(strs[idx]);
        }

        for(pair<const string, vector<string>>& pair: groups) {
            result.push_back(pair.second);
        }

        return result;
    }
};