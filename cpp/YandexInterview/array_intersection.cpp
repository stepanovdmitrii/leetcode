#include <vector>
#include <unordered_map>
#include <iostream>
#include <algorithm>

/*
Даны два массива: [1, 2, 3, 2, 0] и [5, 1, 2, 7, 3, 2]
Надо вернуть [1, 2, 2, 3] (порядок неважен)
*/

std::vector<int> intersection(const std::vector<int> &first, const std::vector<int> &second)
{
    std::vector<int> result;
    if (first.size() == 0 || second.size() == 0)
    {
        return result;
    }
    std::unordered_map<int, size_t> storage;
    for (const int &v : first)
    {
        storage[v]++;
    }
    result.reserve(storage.size());
    for (const int &v : second)
    {
        if (storage.find(v) != storage.end() && storage[v] > 0)
        {
            result.push_back(v);
            storage[v]--;
        }
    }
    return result;
}

int main()
{
    if (intersection({}, {}) != std::vector<int>{})
    {
        std::cerr << "empty failed";
    }
    if (intersection({}, {1, 2, 3}) != std::vector<int>{})
    {
        std::cerr << "empty / non empty failed";
    }
    if (intersection({1, 2, 3}, {}) != std::vector<int>{})
    {
        std::cerr << "non empty / empty failed";
    }
    if (intersection({1, 2, 3}, {4,5,6}) != std::vector<int>{})
    {
        std::cerr << "non empty / non empty failed";
    }
    std::vector<int> result = intersection({1, 2, 3, 2, 0}, {5, 1, 2, 7, 3, 2});
    std::sort(result.begin(), result.end());
    if (result != std::vector<int>{1,2,2,3})
    {
        std::cerr << "non empty / non empty failed";
    }

    result = intersection({1, 2, 3, 4, 5}, {1, 2, 3, 4, 5});
    std::sort(result.begin(), result.end());
    if (result != std::vector<int>{1,2,3,4,5})
    {
        std::cerr << "non empty / non empty failed";
    }

    return 0;
}