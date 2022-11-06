#include <vector>
#include <stack>

using namespace std;

class Solution {
public:
    void dfs(vector<vector<char>>& board, size_t row, size_t column, vector<vector<bool>>& visited) {
        if(board[row][column] != 'O' || visited[row][column]) {
            return;
        }

        vector<pair<size_t, size_t>> cells;
        bool replace = true;
        stack<pair<size_t, size_t>> s;
        s.push(make_pair(row, column));
        while(false == s.empty()) {
            pair<size_t, size_t> current = s.top();
            s.pop();

            if(current.first == 0 || (current.first + 1 == board.size()) ||
               current.second == 0 || (current.second + 1 == board[current.first].size())) {
                replace = false;
            }

            visited[current.first][current.second] = true;
            cells.push_back(current);

            if(current.first > 0 && board[current.first - 1][current.second] == 'O' && false == visited[current.first - 1][current.second]){
                s.push(make_pair(current.first - 1, current.second));
            }

            if(current.first + 1 < board.size() && board[current.first + 1][current.second] == 'O' && false == visited[current.first + 1][current.second]){
                s.push(make_pair(current.first + 1, current.second));
            }

            if(current.second > 0 && board[current.first][current.second - 1] == 'O' && false == visited[current.first][current.second - 1]) {
                s.push(make_pair(current.first, current.second - 1));
            }

            if(current.second + 1 < board[current.first].size() && board[current.first][current.second + 1] == 'O' && false == visited[current.first][current.second + 1]) {
                s.push(make_pair(current.first, current.second + 1));
            }
        }

        if(replace) {
            for(const auto& c : cells) {
                board[c.first][c.second] = 'X';
            }
        }
    }
    
    void solve(vector<vector<char>>& board) {
        vector<vector<bool>> visited(board.size(), vector<bool>(board[0].size(), false));

        for(size_t row = 0; row < board.size(); ++row){
            for(size_t column = 0; column < board[row].size(); ++column) {
                dfs(board, row, column, visited);
            }
        }
    }
};