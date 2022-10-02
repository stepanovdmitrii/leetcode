#include <string>
#include <unordered_set>

using namespace std;

class Solution {
public:
    int lengthOfLongestSubstring(string s) {
        if(s.size() <= 1) {
            return (int)s.size();
        }
        
        size_t result = 0;
        unordered_set<char> unique;
        size_t left = 0;
        size_t right = 1;
        unique.insert(s[left]);
        while (right < s.size())
        {
            auto it = unique.insert(s[right]);
            if(it.second){
                ++right;
                continue;
            }

            result = result > right - left ? result : right - left;

            while (s[left] != s[right])
            {
                char ch = s[left];
                unique.erase(ch);
                ++left;
            }
            ++left;
            ++right;
        }
        result = result > right - left ? result : right - left;
        return (int)result;
    }
};