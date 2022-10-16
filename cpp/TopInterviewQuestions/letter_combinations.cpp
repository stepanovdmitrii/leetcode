#include <vector>
#include <string>
#include <unordered_map>

using namespace std;

class Solution
{

public:
    vector<string> letterCombinations(string digits)
    {
        if(digits.length() == 0) {
            return {};
        }
        unordered_map<char, vector<char>> chars;
        chars['2'] = {'a', 'b', 'c'};
        chars['3'] = {'d', 'e', 'f'};
        chars['4'] = {'g', 'h', 'i'};
        chars['5'] = {'j', 'k', 'l'};
        chars['6'] = {'m', 'n', 'o'};
        chars['7'] = {'p', 'q', 'r', 's'};
        chars['8'] = {'t', 'u', 'v'};
        chars['9'] = {'w', 'x', 'y', 'z'};
        chars['0'] = {' '};
        vector<string> last = {""};
        for(const char& ch: digits) {
            auto it = chars.find(ch);
            if(it == chars.end()) {
                continue;
            }
            vector<string> next;
            for(const char& append: it->second) {
                for(const string& str: last) {
                    next.push_back(str + append);
                }
            }
            last = std::move(next);
        }

        return last;
    }
};