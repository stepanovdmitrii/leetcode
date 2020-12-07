using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Arrays
{
    class SpiralMatrixSolution
    {
        public int[][] GenerateMatrix(int n)
        {
            var result = new int[n][];
            for(int row = 0; row < result.Length; ++row)
            {
                result[row] = new int[n];
            }
            int offsetLimit = n % 2 == 0 ? (n - 1) / 2 : n / 2;
            int start = 1;
            for(int offset = 0; offset <= offsetLimit; ++offset)
            {
                FillRing(result, offset, start, n, out start);
            }

            return result;
        }

        private void FillRing(int[][] result, int offset, int start, int size, out int next)
        {
            for(int col = 0 + offset; col <= size - 1 - offset; ++col)
            {
                result[0 + offset][col] = start;
                ++start;
            }

            for(int row = 1 + offset; row <= size - 1 - offset; ++row)
            {
                result[row][size - 1 - offset] = start;
                ++start;
            }

            for(int col = size - 2 - offset; col >= 0 + offset; --col)
            {
                result[size - 1 - offset][col] = start;
                ++start;
            }

            for(int row = size - 2 - offset; row > 0 + offset; --row)
            {
                result[row][0 + offset] = start;
                ++start;
            }

            next = start;
        }
    }
}
