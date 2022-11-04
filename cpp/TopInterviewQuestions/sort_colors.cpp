#include <vector>

using namespace std;

class Solution {
public:
    void sortColors(vector<int>& nums) {
        size_t red = 0;
        size_t white = 0;
        size_t blue = 0;

        for(const int v : nums) {
            if(v == 0) {
                ++red;
            } else if (v == 1) {
                ++white;
            } else if (v == 2) {
                ++blue;
            }
        }

        for(size_t idx = 0 ; idx < nums.size(); ++idx) {
            if(red != 0) {
                nums[idx] = 0;
                --red;
                continue;
            }

            if(white != 0) {
                nums[idx] = 1;
                --white;
                continue;
            }

            if(blue != 0) {
                nums[idx] = 2;
                --blue;
                continue;
            }
        }
    }
};