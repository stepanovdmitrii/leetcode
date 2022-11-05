#include <vector>
#include <string>

using namespace std;

class Solution
{
public:
    bool dfs(vector<vector<char>> &board, size_t row, size_t column, string word, vector<vector<bool>> &visited, size_t idx)
    {
        if (idx == word.size())
        {
            return true;
        }

        if (visited[row][column])
        {
            return false;
        }

        if (board[row][column] != word[idx])
        {
            return false;
        }

        visited[row][column] = true;
        if (row > 0 && dfs(board, row - 1, column, word, visited, idx + 1))
        {
            return true;
        }

        if (column > 0 && dfs(board, row, column - 1, word, visited, idx + 1))
        {
            return true;
        }

        if (row + 1 < board.size() && dfs(board, row + 1, column, word, visited, idx + 1))
        {
            return true;
        }

        if (column + 1 < board[row].size() && dfs(board, row, column + 1, word, visited, idx + 1))
        {
            return true;
        }
        visited[row][column] = false;

        return idx + 1 == word.size();
    }
    bool dfs(vector<vector<char>> &board, size_t row, size_t column, string word)
    {
        if (word.size() == 0)
        {
            return true;
        }
        if (word[0] != board[row][column])
        {
            return false;
        }
        vector<vector<bool>> visited(board.size(), vector<bool>(board[row].size(), false));
        return dfs(board, row, column, word, visited, 0);
    }
    bool exist(vector<vector<char>> &board, string word)
    {
        for (size_t row = 0; row < board.size(); ++row)
        {
            for (size_t column = 0; column < board[row].size(); ++column)
            {
                if (dfs(board, row, column, word))
                {
                    return true;
                }
            }
        }
        return false;
    }
};

//[["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]]
int main()
{
    vector<vector<char>> data = {
        {'A'},
    };
    Solution s;
    bool result = s.exist(data, "A");
}