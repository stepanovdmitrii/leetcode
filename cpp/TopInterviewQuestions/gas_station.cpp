#include <vector>

using namespace std;

class Solution {
public:
    int canCompleteCircuit(vector<int>& gas, vector<int>& cost) {
        vector<int> diff(gas.size(), 0);
        int sum = 0;
        for(size_t idx = 0; idx < gas.size(); ++idx) {
            diff[idx] = gas[idx] - cost[idx];
            sum += diff[idx];
        }

        if(sum < 0) {
            return -1;
        }

        sum = 0;
        int result = -1;
        for(size_t idx = 0; idx < 2 * diff.size(); ++idx) {
            size_t i = idx % diff.size();
            if(i == result){
                return result;
            }
            sum += diff[i];
            if(sum < 0) {
                result = -1;
                sum = 0;
                continue;
            }
            if(result == -1) {
                result = i;
            }
        }
        return -1;
    }
};


int main() {
    Solution s;
    vector<int> gas{1,2,3,4,5};
    vector<int> cost{3,4,5,1,2};
    s.canCompleteCircuit(gas, cost);
}