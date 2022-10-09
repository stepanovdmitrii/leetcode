#include <string>
#include <algorithm>
#include <vector>
#include <iostream>

using namespace std;

/*
Input:
"aacabdkacaa"
Output:
"aaca"
Expected:
"aca"
*/

class Solution {
public:
    string longestPalindrome(string s) {
        string str(s.size() * 2 + 1, '|');
        for(size_t idx = 0; idx < s.size(); ++idx) {
            str[2*idx + 1] = s[idx];
        }

        vector<int> max_length(str.size(), 0);
        int left = 0;
        int right = -1;

        int max_len_radius = -1;
        int max_len_idx = -1;

        for(int idx = 0; idx < str.size(); ++idx) {
            int radius = idx > right ? 1 : min(max_length[left + right - idx], right - idx + 1);
            while(idx + radius < str.size() && idx - radius >= 0 && str[idx - radius] == str[idx + radius]) {
                ++radius;
            }
            max_length[idx] = radius;
            if(radius > max_len_radius) {
                max_len_idx = idx;
                max_len_radius = radius;
            }
            if(idx + radius - 1 > right){
                left = idx - radius + 1;
                right = idx + radius - 1;
            }  
        }

        string result;
        for(int i = max_len_idx - max_len_radius + 1; i <= max_len_idx + max_len_radius - 1; ++i) {
            if(str[i] != '|') {
                result += str[i];
            }
        }
        return result;
    }
};

int main()
{
    Solution s;
    cout << s.longestPalindrome("babad");
}