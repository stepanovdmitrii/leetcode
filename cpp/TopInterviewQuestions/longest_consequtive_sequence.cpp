#include <vector>
#include <unordered_map>
#include <unordered_set>

using namespace std;


class Solution {
public:
    int longestConsecutive(vector<int>& nums) {
        int result = 0;
        unordered_set<int> visited;
        unordered_map<int, int> intervals;
        for(auto v : nums) {
            if(visited.find(v) != visited.end()){
                continue;
            }
            visited.insert(v);

            int start = v;
            int end = v;

            auto lower = intervals.find(v - 1);
            if(lower != intervals.end()) {
                start = lower->second;
                int drop_start = lower->second;
                int drop_end = lower->first;
                intervals.erase(drop_start);
                intervals.erase(drop_end);
            }

            auto upper = intervals.find(v + 1);
            if(upper != intervals.end()) {
                end = upper->second;
                int drop_start = upper->first;
                int drop_end = upper->second;
                intervals.erase(drop_start);
                intervals.erase(drop_end);
            }

            result = result > (end - start + 1) ? result : (end - start + 1);
            intervals[start] = end;
            intervals[end] = start;
        }
        return result;
    }
};