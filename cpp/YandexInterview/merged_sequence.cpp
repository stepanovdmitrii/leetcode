#include <vector>
#include <algorithm>
#include <iostream>

/*
Дан массив из нулей и единиц. Нужно определить, какой максимальный по длине подинтервал единиц можно получить, удалив ровно один элемент массива.
[1, 1, 0]
*/

size_t num_of_merged_sequences(const std::vector<int> &source)
{
    size_t current = 0;
    size_t prev = 0;
    size_t maximum = 0;
    bool has_zero = false;

    for (const int &v : source)
    {
        if (v == 1)
        {
            ++current;
            maximum = std::max(maximum, current + prev);
            continue;
        }
        
        prev = current;
        current = 0;
        has_zero = true;
    }
    if (false == has_zero)
    {
        return 0;
    }

    return maximum;
}

int main()
{
    if (num_of_merged_sequences({1, 1, 0, 1, 0}) != 3)
    {
        std::cerr << "failed example 1";
    }

    if (num_of_merged_sequences({}) != 0)
    {
        std::cerr << "failed empty";
    }
    if (num_of_merged_sequences({0}) != 0)
    {
        std::cerr << "failed one zero";
    }

    if (num_of_merged_sequences({0, 0, 0, 0, 0}) != 0)
    {
        std::cerr << "failed all zeros";
    }

    if (num_of_merged_sequences({1, 1, 1, 1, 1}) != 0)
    {
        std::cerr << "failed all ones";
    }

    if (num_of_merged_sequences({1, 1, 0, 0, 1, 1, 1, 0, 0}) != 3)
    {
        std::cerr << "failed example 2";
    }

    if (num_of_merged_sequences({1, 1, 0, 0, 1, 1, 1, 0, 1, 1}) != 5)
    {
        std::cerr << "failed example 3";
    }

    if (num_of_merged_sequences({0, 0, 0, 1, 1}) != 2)
    {
        std::cerr << "failed example 4";
    }

    if (num_of_merged_sequences({1, 1, 0, 0, 0}) != 2)
    {
        std::cerr << "failed example 5";
    }
    return 0;
}