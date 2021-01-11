using System.Collections.Generic;

namespace LeetCode.Recursion
{
    public sealed class SolveSudokuSolution
    {
        private const int Size = 9;
        private const int PartSize = 3;
        private const char Empty = '.';

        private static readonly char[] All = new[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private bool _solved = false;

        public void SolveSudoku(char[][] board)
        {
            _solved = false;
            Process(0, 0, board);
        }

        private void Process(int row, int column, char[][] board)
        {
            if(IsOutside(row, column))
            {
                _solved = true;
                return;
            }

            GetNextIndicies(row, column, out int nextRow, out int nextColumn);

            if (IsFilled(row, column, board))
            {
                Process(nextRow, nextColumn, board);
            }
            else
            {
                var available = GetAvailable(row, column, board);
                if (available.Count == 0) return;

                foreach (var number in available)
                {
                    board[row][column] = number;
                    Process(nextRow, nextColumn, board);
                    if (_solved) return;
                }

                board[row][column] = Empty;
            }
        }

        private static HashSet<char> GetAvailable(int row, int column, char[][] board)
        {
            var result = new HashSet<char>(All);
            for(int idx = 0; idx < Size; ++idx)
            {
                char ch = board[row][idx];
                result.Remove(ch);
                ch = board[idx][column];
                result.Remove(ch);
            }

            int minRow = (row / PartSize) * PartSize;
            int minCol = (column / PartSize) * PartSize;
            
            for(int r = minRow; r < minRow + PartSize; ++r)
            {
                for(int c = minCol; c < minCol + PartSize; ++c)
                {
                    result.Remove(board[r][c]);
                }
            }

            return result;
        }

        private static bool IsFilled(int row, int column, char[][] board)
        {
            return board[row][column] != Empty;
        }

        private static bool IsOutside(int row, int column)
        {
            return row == 9 || column == 9;
        }

        private static void GetNextIndicies(int row, int column, out int nextRow, out int nextColumn)
        {
            nextColumn = (column + 1) % Size;
            nextRow = row + (column + 1) / Size;
        }
    }
}
