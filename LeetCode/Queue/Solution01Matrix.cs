using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Queue
{
    class Solution01Matrix
    {
        public int[][] UpdateMatrix(int[][] matrix)
        {
            var result = new int[matrix.Length][];

            var buffer = new Queue<Tuple<int, int>>();

            for (int r = 0; r < matrix.Length; ++r)
            {
                result[r] = new int[matrix[r].Length];
                for (int c = 0; c < result[r].Length; ++c)
                {
                    if (matrix[r][c] != 0)
                    {
                        result[r][c] = int.MaxValue;
                    }
                    else
                    {
                        buffer.Enqueue(new Tuple<int, int>(r, c));
                    }
                }
            }

            while(buffer.Count > 0)
            {
                var current = buffer.Dequeue();

                var upper = new Tuple<int, int>(current.Item1 - 1, current.Item2);
                var bottom = new Tuple<int, int>(current.Item1 + 1, current.Item2);
                var left = new Tuple<int, int>(current.Item1, current.Item2 - 1);
                var right = new Tuple<int, int>(current.Item1, current.Item2 + 1);

                if (upper.Item1 >= 0 && result[current.Item1][current.Item2] + 1 < result[upper.Item1][upper.Item2])
                {
                    result[upper.Item1][upper.Item2] = result[current.Item1][current.Item2] + 1;
                    buffer.Enqueue(upper);
                }

                if (bottom.Item1 < matrix.Length && result[current.Item1][current.Item2] + 1 < result[bottom.Item1][bottom.Item2])
                {
                    result[bottom.Item1][bottom.Item2] = result[current.Item1][current.Item2] + 1;
                    buffer.Enqueue(bottom);
                }

                if (left.Item2 >= 0 && result[current.Item1][current.Item2] + 1 < result[left.Item1][left.Item2])
                {
                    result[left.Item1][left.Item2] = result[current.Item1][current.Item2] + 1;
                    buffer.Enqueue(left);
                }

                if (right.Item2 < matrix[right.Item1].Length && result[current.Item1][current.Item2] + 1 < result[right.Item1][right.Item2])
                {
                    result[right.Item1][right.Item2] = result[current.Item1][current.Item2] + 1;
                    buffer.Enqueue(right);
                }
            }

            return result;
        }
    }
}
