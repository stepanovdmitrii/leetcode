#include <vector>
#include <algorithm>

using namespace std;

class Solution {
public:
    int maxProduct(vector<int>& nums) {
        int result = 0;
        vector<int> max_values(nums.size(), 0);
        vector<int> min_values(nums.size(), 0);
        max_values[0] = min_values[0] = nums[0];
        for(size_t idx = 1; idx < nums.size(); ++idx){
            vector<int> v(3, 0);
            v[0] = nums[idx];
            v[1] = max_values[idx - 1] * nums[idx];
            v[2] = min_values[idx - 1] * nums[idx];
            sort(v.begin(), v.end());
            max_values[idx] = v[2];
            min_values[idx] = v[0];
            result = result > max_values[idx] ? result : max_values[idx];
        }
        return result;
    }
};


/*
        int ans = -10
        int maxi = 1;
        int mini = 1;
        for(int i=0;i<nums.size();i++){
            if(nums[i] < 0) swap(maxi, mini);
            maxi = max(maxi*nums[i], nums[i]);
            mini = min(mini*nums[i], nums[i]);
            ans = max(maxi, ans);
        }
        return ans;

*/