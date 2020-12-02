using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace LeetCode.Queue
{
    class NumIslandsSolution
    {
        public int NumIslands(char[][] grid)
        {
            if (grid == null || grid.Length == 0 || grid[0].Length == 0) return 0;

            int result = 0;
            for(int row = 0; row < grid.Length; ++row)
            {
                for(int col = 0; col < grid[row].Length; ++col)
                {
                    if (grid[row][col] == '1')
                    {
                        Visit(grid, row, col, grid.Length, grid[0].Length);
                        ++result;
                    }
                }
            }
            return result;
        }

        private static void Visit(char[][] grid, int row, int col, int rows, int cols)
        {
            if(row >= 0 && row < rows && col >= 0 && col < cols && grid[row][col] == '1')
            {
                grid[row][col] = '0';
                Visit(grid, row + 1, col, rows, cols);
                Visit(grid, row - 1, col, rows, cols);
                Visit(grid, row, col + 1, rows, cols);
                Visit(grid, row, col - 1, rows, cols);
            }
        }
    }
}
