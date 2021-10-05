#include <unordered_map>
#include <vector>
#include <string>
#include <algorithm>

/*
Sample Input ["eat", "tea", "tan", "ate", "nat", "bat"]
Sample Output [ ["ate", "eat", "tea"], ["nat", "tan"], ["bat"] ]

Т.е. сгруппировать слова по "общим буквам".
*/

std::vector<std::vector<std::string>> group_by_same_chars(const std::vector<std::string>& strings) {
    std::unordered_map<std::string, std::vector<std::string>> acc;
    std::string key;
    for(const std::string& s : strings) {
        key = s;
        std::sort(key.begin(), key.end());
        acc[key].push_back(s);
    }
    std::vector<std::vector<std::string>> result;
    result.reserve(acc.size());
    for(const auto& p : acc) {
        result.push_back(std::move(p.second));
    }
    return result;
}
