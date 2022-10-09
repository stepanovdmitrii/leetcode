#include <vector>

using namespace std;

class Solution {
public:
    int majorityElement(vector<int>& nums) {
        int result = 0;
        size_t counter = 0;
        for(size_t idx = 0; idx < nums.size(); ++idx) {
            if(counter == 0) {
                result = nums[idx];
                ++counter;
                continue;
            }

            if(nums[idx] == result) {
                ++counter;
            } else {
                --counter;
            }
        }
        return result;   
    }
};