#include <vector>
#include <algorithm>

struct segment {
    size_t begin;
    size_t end;
};

/*
Слияние отрезков:

Вход: [1, 3] [100, 200] [2, 4]
Выход: [1, 4] [100, 200]
*/

std::vector<segment> merge(std::vector<segment> source) {
    std::vector<segment> result;
    if(source.size() < 2) {
        return result;
    }

    result.reserve(source.size());

    std::sort(source.begin(), source.end(), [](const segment& lhs, const segment& rhs){
        if(lhs.begin == rhs.begin) {
            return lhs.end < rhs.end;
        }
        return lhs.begin < rhs.begin;
    });

    segment current = source[0];
    for(size_t idx = 1; idx < source.size(); ++idx) {
        if(source[idx].begin <= current.end) {
            current.end = std::max(current.end, source[idx].end);
            continue;
        }

        result.push_back(current);
        current = source[idx];
    }
    result.push_back(current);

    return result;
}