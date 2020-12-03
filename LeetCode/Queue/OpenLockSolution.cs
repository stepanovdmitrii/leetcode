using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Queue
{
    public sealed class OpenLockSolution
    {
        public int OpenLock(string[] deadends, string target)
        {
            var visited = new HashSet<int>();

            foreach(var node in deadends)
            {
                if (node == "0000") return -1;

                visited.Add(int.Parse(node));
            }
            if (visited.Contains(int.Parse(target))) return -1;
            return Find(visited, int.Parse(target));
        }

        private int Find(HashSet<int> visited, int target)
        {
            int path = 0;
            var nodeBatch = new List<int>();
            nodeBatch.Add(target);
            while(nodeBatch.Count > 0)
            {
                var nextBatch = new List<int>();

                foreach(var node in nodeBatch)
                {
                    if (node == 0) return path;

                    foreach(var next in GetNext(node))
                    {
                        if(false == visited.Contains(next))
                        {
                            nextBatch.Add(next);
                        }
                    }

                    visited.Add(node);
                }

                nodeBatch = nextBatch;
                ++path;
            }
            return -1;
        }

        private static IEnumerable<int> GetNext(int node)
        {
            var arr = ToArray(node);

            for(int i = 0; i < arr.Length; ++i)
            {
                int original = arr[i];
                arr[i] = GetNextValue(original);
                yield return ToValue(arr);
                arr[i] = GetPreviousValue(original);
                yield return ToValue(arr);
                arr[i] = original;
            }

        }

        private static int[] ToArray(int n)
        {
            var result = new int[4];
            for(int i = 0; i < result.Length; ++i)
            {
                result[result.Length - 1 - i] = n % 10;
                n = n / 10;
            }
            return result;
        }

        private static int ToValue(int[] arr)
        {
            int result = 0;
            int m = 1000;
            for(int i = 0; i < arr.Length; ++i)
            {
                result += arr[i] * m;
                m = m / 10;
            }

            return result;
        }

        private static int GetNextValue(int ch)
        {
            if (ch == 9) return 0;
            return ch + 1;
        }

        private static int GetPreviousValue(int ch)
        {
            if (ch == 0) return 9;
            return ch - 1;
        }
    }
}
