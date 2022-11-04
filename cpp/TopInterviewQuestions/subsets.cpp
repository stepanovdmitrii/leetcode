#include <vector>

using namespace std;


class Solution {
public:
    void subset(const vector<int>& nums, vector<vector<int>>& result, vector<int>& current, size_t idx) {
        if(idx == nums.size()){
            return;
        }

        for(size_t i = idx; i < nums.size(); ++i) {
            vector<int> next(current);
            next.push_back(nums[i]);
            result.push_back(next);
            subset(nums, result, next, i+1);
        }
    }

    vector<vector<int>> subsets(vector<int>& nums) {
        vector<vector<int>> result;
        vector<int> current;
        result.push_back(current);
        subset(nums, result, current, 0);
        return result;
    }
};