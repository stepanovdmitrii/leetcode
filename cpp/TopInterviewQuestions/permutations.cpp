#include <vector>

using namespace std;

class Solution {
public:
    void permute(vector<vector<int>>& result, vector<int>& nums, size_t idx) {
        if(idx == nums.size()) {
            result.push_back(nums);
            return;
        }
        for(size_t next = idx; next < nums.size(); ++next) {
            swap(nums[idx], nums[next]);
            permute(result, nums, idx + 1);
            swap(nums[idx], nums[next]);
        }
    }

    vector<vector<int>> permute(vector<int>& nums) {
        vector<vector<int>> result;
        result.reserve(6*5*4*3*2*1);

        permute(result, nums, 0);

        return result;
    }
};