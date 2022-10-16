#include <vector>
#include <iostream>

using namespace std;

class Solution {
public:
    int maxArea(vector<int>& height) {
        if(height.size() <= 1) {
            return 0;
        }
        size_t result = 0;
        size_t left = 0;
        size_t right = height.size() - 1;

        while(left < right) {
            size_t current = (right - left) * min(height[left], height[right]);
            if(current > result) {
                result = current;
            }
            if(height[left] < height[right]) {
                ++left;
            } else {
                --right;
            }
        }

        return (int)result;
    }
};

int main() {
    Solution s;
    vector<int> v{1,8,6,2,5,4,8,3,7};
    cout << s.maxArea(v) << endl;
    return 0;
}