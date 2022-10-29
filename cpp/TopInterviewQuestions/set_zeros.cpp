#include <vector>

using namespace std;

class Solution
{
public:
    void setZeroes(vector<vector<int>> &matrix)
    {
        if (matrix.size() == 0 || matrix[0].size() == 0)
        {
            return;
        }

        bool zeroFirstRow = matrix[0][0] == 0;
        bool zeroFirstColumn = matrix[0][0] == 0;

        for (size_t row = 0; row < matrix.size(); ++row)
        {
            for (size_t column = 0; column < matrix[row].size(); ++column)
            {
                if (matrix[row][column] != 0)
                {
                    continue;
                }

                if (row == 0)
                {
                    zeroFirstRow = true;
                    continue;
                }

                if (column == 0)
                {
                    zeroFirstColumn = true;
                    continue;
                }

                matrix[0][column] = 0;
                matrix[row][0] = 0;
            }
        }

        for (size_t row = 1; row < matrix.size(); ++row)
        {
            if (matrix[row][0] == 0)
            {
                for (size_t column = 1; column < matrix[row].size(); ++column)
                {
                    matrix[row][column] = 0;
                }
            }
        }

        for (size_t column = 1; column < matrix[0].size(); ++column)
        {
            if (matrix[0][column] == 0)
            {
                for (size_t row = 1; row < matrix.size(); ++row)
                {
                    matrix[row][column] = 0;
                }
            }
        }

        if (zeroFirstColumn)
        {
            for (size_t row = 0; row < matrix.size(); ++row)
            {
                matrix[row][0] = 0;
            }
        }

        if (zeroFirstRow)
        {
            for (size_t column = 0; column < matrix[0].size(); ++column)
            {
                matrix[0][column] = 0;
            }
        }
    }
};