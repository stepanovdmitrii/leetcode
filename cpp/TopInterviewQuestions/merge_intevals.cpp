#include <vector>
#include <algorithm>

using namespace std;


class Solution {
public:
    vector<vector<int>> merge(vector<vector<int>>& intervals) {
        sort(intervals.begin(), intervals.end(), [](const vector<int>& lhs, const vector<int>& rhs) {
            if(lhs[0] == rhs[0]){
                return lhs[1] < rhs[1];
            }
            return lhs[0] < rhs[0];
        });

        vector<vector<int>> result;

        vector<int> current;
        for(size_t idx = 0; idx < intervals.size(); ++idx) {
            if(current.size() == 0) {
                current = intervals[idx];
                continue;
            }

            if(current[1] >= intervals[idx][0]) {
                current[1] = max(current[1], intervals[idx][1]);
            } else {
                result.push_back(current);
                current = intervals[idx];
            }
        }

        if(current.size() > 0) {
            result.push_back(current);
        }


        return result;

    }
};