using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Queue
{
    class FloodFillSolution
    {
        public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            int color = image[sr][sc];
            if (color == newColor) return image;

            var queue = new Queue<Tuple<int, int>>();
            var visited = new HashSet<Tuple<int, int>>();
            queue.Enqueue(new Tuple<int, int>(sr, sc));
            visited.Add(new Tuple<int, int>(sr, sc));

            while(queue.Count > 0)
            {
                var current = queue.Dequeue();
                image[current.Item1][current.Item2] = newColor;

                var upper = new Tuple<int, int>(current.Item1 - 1, current.Item2);
                var bottom = new Tuple<int, int>(current.Item1 + 1, current.Item2);
                var left = new Tuple<int, int>(current.Item1, current.Item2 - 1);
                var right = new Tuple<int, int>(current.Item1, current.Item2 + 1);

                if(upper.Item1 >= 0 && image[upper.Item1][upper.Item2] == color && visited.Add(upper))
                {
                    queue.Enqueue(upper);
                }

                if (bottom.Item1 < image.Length && image[bottom.Item1][bottom.Item2] == color && visited.Add(bottom))
                {
                    queue.Enqueue(bottom);
                }

                if (left.Item2 >= 0 && image[left.Item1][left.Item2] == color && visited.Add(left))
                {
                    queue.Enqueue(left);
                }

                if (right.Item2 < image[right.Item1].Length && image[right.Item1][right.Item2] == color && visited.Add(right))
                {
                    queue.Enqueue(right);
                }
            }

            return image;
        }
    }
}
