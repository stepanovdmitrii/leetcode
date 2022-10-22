#include <vector>
#include <unordered_set>

using namespace std;

class Solution {
public:
    bool canJump(vector<int>& nums, unordered_set<int>& visited, int idx) {
        if(idx >= nums.size()){
            return true;
        }
        auto it = visited.find(idx);
        if(it != visited.end()) {
            return false;
        }

        visited.insert(idx);
        if(idx == nums.size() - 1) {
            return true;
        }
        for(int i = nums[idx]; i > 0; --i) {
            if(canJump(nums, visited, idx + i)){
                return true;
            }
        }
        return false;
    }
    bool canJump(vector<int>& nums) {
        if(nums.size() <= 1) {
            return true;
        }
        unordered_set<int> visited;
        return canJump(nums, visited, 0);
    }
};

int main() {
    Solution s;
    vector<int> v = {3,2,1,0,4};
    bool result = s.canJump(v);
}