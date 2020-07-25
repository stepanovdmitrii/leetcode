using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Arrays
{
    class ValidSudokuSolution
    {
        public bool IsValidSudoku(char[][] board)
        {
            var cols = new HashSet<int>[9];
            var cells = new HashSet<int>[9];
            for (int i = 0; i < 9; ++i)
            {
                cols[i] = new HashSet<int>();
                cells[i] = new HashSet<int>();
            }

            for(int row = 0; row < 9; ++row)
            {
                var rowValues = new HashSet<int>();
                for(int col = 0; col < 9; ++col)
                {
                    if (board[row][col] == '*') continue;
                    int value = int.Parse(board[row][col].ToString());
                    if (false == rowValues.Add(value)) return false;
                    if (false == cols[col].Add(value)) return false;
                    int cellRow = row / 3;
                    int cellCol = col / 3;
                    int index = cellRow * 3 + cellCol;
                    if (false == cells[index].Add(value)) return false;
                }
            }
            return true;
        }
    }
}
