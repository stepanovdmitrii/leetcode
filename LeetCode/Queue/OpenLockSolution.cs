using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Queue
{
    public sealed class OpenLockSolution
    {
        public int OpenLock(string[] deadends, string target)
        {
            var visited = new bool[10000];

            foreach(var node in deadends)
            {
                if (node == "0000") return -1;

                visited[int.Parse(node)] = true;
            }
            if (visited[int.Parse(target)]) return -1;
            return Find(visited, int.Parse(target));
        }

        private int Find(bool[] visited, int target)
        {
            int path = 0;
            var buffer = new Queue<int>();
            buffer.Enqueue(target);
            while(buffer.Count > 0)
            {
                int count = buffer.Count;
                for(int i = 0; i < count; ++i)
                {
                    var node = buffer.Dequeue();
                    if (node == 0) return path;

                    FillNext(node, visited, buffer);
                }
                ++path;
            }
            return -1;
        }

        private static void FillNext(int node, bool[] visited, Queue<int> buffer)
        {
            int left = node / 10;
            int right = 0;
            int current = node % 10;
            int mult = 1;

            for(int i = 0; i < 4; ++i)
            {
                int up = (left * 10 + (current + 1) % 10) * mult + right;
                int down = (left * 10 + (current + 9) % 10) * mult + right;
                if (false == visited[up]) { buffer.Enqueue(up); visited[up] = true; }
                if (false == visited[down]) { buffer.Enqueue(down); visited[down] = true; }

                right += current * mult;
                mult *= 10;
                current = left % 10;
                left /= 10;
            }
        }
    }
}
