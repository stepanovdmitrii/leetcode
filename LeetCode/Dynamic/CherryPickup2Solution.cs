using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Dynamic
{
    class CherryPickup2Solution
    {
        public int CherryPickup(int[][] grid)
        {
            int columnsCount = grid[0].Length;
            var cache = new int[grid.Length][][];
            for(int row = 0; row < grid.Length; ++row)
            {
                cache[row] = new int[columnsCount][];
                for(int col = 0; col < columnsCount; ++col)
                {
                    cache[row][col] = new int[columnsCount];
                    for(int idx = 0; idx < columnsCount; ++idx)
                    {
                        cache[row][col][idx] = -1;
                    }
                }
            }

            return FindMax(0, 0, grid[0].Length - 1, grid, cache);
        }

        private static int FindMax(int row, int col1, int col2, int[][] grid, int[][][] cache)
        {
            if(col1 < 0 || col1 >= grid[0].Length || col2 < 0 || col2 >= grid[0].Length)
            {
                return 0; //outside boundaries
            }

            if(cache[row][col1][col2] != -1)
            {
                return cache[row][col1][col2];
            }

            int current = grid[row][col1];
            if(col1 != col2)
            {
                current += grid[row][col2];
            }

            int max = 0;

            if (row != grid.Length - 1)
            {
                for (int nextCol1 = col1 - 1; nextCol1 <= col1 + 1; ++nextCol1)
                {
                    for (int nextCol2 = col2 - 1; nextCol2 <= col2 + 1; ++nextCol2)
                    {
                        max = System.Math.Max(max, FindMax(row + 1, nextCol1, nextCol2, grid, cache));
                    }
                }
                current += max;
            }

            cache[row][col1][col2] = current;
            return current;
        }
    }
}
