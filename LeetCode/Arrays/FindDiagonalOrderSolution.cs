using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Arrays
{
    public sealed class FindDiagonalOrderSolution
    {
        public int[] FindDiagonalOrder(int[][] matrix)
        {
            if (matrix == null) return null;

            int rows = matrix.Length;
            if (rows == 0) return new int[0];

            int cols = matrix[0].Length;
            if (cols == 0) return new int[0];

            var result = new int[rows * cols];
            int idx = 0;
            int row_diff = -1;
            int col_diff = 1;

            int diags = cols + rows - 1;
            bool upRight = true;

            for(int diagIdx = 0; diagIdx < diags; ++diagIdx)
            {
                int row = upRight ? System.Math.Min(diagIdx, rows - 1) : System.Math.Max(0, diagIdx - cols + 1);
                int col = upRight ? System.Math.Max(0, diagIdx - rows + 1) : System.Math.Min(diagIdx, cols - 1);

                while (row >= 0 && row < rows && col >= 0 && col < cols)
                {
                    result[idx] = matrix[row][col];
                    ++idx;
                    row += row_diff;
                    col += col_diff;
                }

                upRight = !upRight;
                row_diff *= -1;
                col_diff *= -1;
            }

            return result;
        }
    }
}
