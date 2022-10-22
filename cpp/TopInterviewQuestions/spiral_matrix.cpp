#include <vector>
#include <iostream>

using namespace std;

class Solution
{
public:
    vector<int> spiralOrder(vector<vector<int>> &matrix)
    {
        vector<int> result;
        if (matrix.size() == 0 || matrix[0].size() == 0)
        {
            return result;
        }
        result.reserve(matrix.size() * matrix[0].size());
        size_t start_column = 0;
        size_t end_column = matrix[0].size() - 1;
        size_t start_row = 0;
        size_t end_row = matrix.size() - 1;
        bool has_next = true;

        while (has_next)
        {
            has_next = false;
            for (size_t col = start_column; start_row <= end_row && col <= end_column; ++col)
            {
                result.push_back(matrix[start_row][col]);
                has_next = true;
            }

            for (size_t row = start_row + 1; row <= end_row && start_column <= end_column; ++row)
            {
                result.push_back(matrix[row][end_column]);
                has_next = true;
            }

            if (end_column > 0)
            {
                for (size_t col = end_column - 1; start_column < end_column && start_row < end_row && col > start_column; --col)
                {
                    result.push_back(matrix[end_row][col]);
                    has_next = true;
                }
            }

            if (end_row > 0) {
                for(size_t row = end_row; row > start_row && start_row < end_row && start_column < end_column; --row) {
                    result.push_back(matrix[row][start_column]);
                    has_next = true;
                }
            }

            ++start_row;
            ++start_column;
            if(end_column > 0) {
                --end_column;
            }
            if(end_row > 0) {
                --end_row;
            }
        }

        return result;
    }
};

int main()
{
    vector<vector<int>> matrix = {
        {1, },};
    Solution s;
    vector<int> result = s.spiralOrder(matrix);
    for (int v : result)
    {
        cout << v << " ";
    }
    return 0;
}