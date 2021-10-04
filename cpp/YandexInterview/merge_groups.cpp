#include <string>
#include <vector>
#include <algorithm>
#include <iostream>

/*
Дан список интов, повторяющихся элементов в списке нет. Нужно преобразовать это множество в строку, сворачивая соседние по числовому ряду числа в диапазоны. Примеры:
[1,4,5,2,3,9,8,11,0] => "0-5,8-9,11"
[1,4,3,2] => "1-4"
[1,4] => "1,4"
*/

void append(std::string &result, std::vector<int> &source, size_t start, size_t end)
{
    if (result.size() > 0)
    {
        result += ",";
    }
    if (start == end)
    {
        result += std::to_string(source[start]);
    }
    else
    {
        result += std::to_string(source[start]);
        result += "-";
        result += std::to_string(source[end]);
    }
}

std::string group(std::vector<int> &source)
{
    if (source.size() == 0)
    {
        return "";
    }
    std::sort(source.begin(), source.end());
    std::string result;
    size_t start = 0;
    for (size_t idx = 1; idx < source.size(); ++idx)
    {
        if (source[idx] == source[idx - 1] + 1)
        {
            continue;
        }

        size_t end = idx - 1;
        append(result, source, start, end);
        start = idx;
    }
    append(result, source, start, source.size() - 1);
    return result;
}

int main()
{
    std::vector<int> source;
    source = {};
    if(group(source) != "") {
        std::cerr << "failed empty";
    }

    source = {1};
    if(group(source) != "1") {
        std::cerr << "failed single";
    }

    source = {1,2,3,4,5};
    if(group(source) != "1-5") {
        std::cerr << "failed one group";
    }

    source = {10, 8, 6, 2, 4, 0};
    if(group(source) != "0,2,4,6,8,10") {
        std::cerr << "failed no groups";
    }

    source = {1,4,5,2,3,9,8,11,0};
    if(group(source) != "0-5,8-9,11") {
        std::cerr << "failed example 1";
    }

    source = {1,4,3,2};
    if(group(source) != "1-4") {
        std::cerr << "failed example 2";
    }

    source = {1,4};
    if(group(source) != "1,4") {
        std::cerr << "failed example 3";
    }    
    return 0;
}