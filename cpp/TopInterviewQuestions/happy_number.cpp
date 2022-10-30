#include <unordered_set>
#include <stdint.h>

class Solution {
public:
    uint64_t getNext(uint64_t n) {
        uint64_t result = 0;
        while(n > 0) {
            result += ((n % 10) * (n % 10));
            n /= 10;
        }
        return result;
    }

    bool isHappy(int n) {
        uint64_t value = n;
        std::unordered_set<uint64_t> visited;
        while(value != 1 && visited.find(value) == visited.end()) {
            visited.insert(value);
            value = getNext(value);
        }
        return value == 1;
    }
};

int main() {
    Solution s;
    s.isHappy(19);
    return 0;
}