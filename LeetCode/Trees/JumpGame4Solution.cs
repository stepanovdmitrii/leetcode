using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Trees
{
    public sealed class JumpGame4Solution
    {
        public int MinJumps(int[] arr)
        {
            if (arr == null || arr.Length <= 1) return 0;

            var valueIndex = new Dictionary<int, List<int>>();
            for(int idx = arr.Length - 1; idx > 0; --idx)
            {
                if(valueIndex.TryGetValue(arr[idx], out var indicies))
                {
                    indicies.Add(idx);
                }
                else
                {
                    valueIndex[arr[idx]] = new List<int> { idx };
                }
            }

            var buffer = new Queue<int>();
            var visited = new HashSet<int>();

            buffer.Enqueue(0);
            visited.Add(0);
            int pathLength = 0;

            while(buffer.Count > 0)
            {
                int count = buffer.Count;
                for(int i = 0; i < count; ++i)
                {
                    int lastIndex = buffer.Dequeue();

                    if(lastIndex + 1 == arr.Length - 1)
                    {
                        return pathLength + 1;
                    }

                    if(false == visited.Contains(lastIndex + 1))
                    {
                        visited.Add(lastIndex + 1);
                        buffer.Enqueue(lastIndex + 1);
                    }

                    if(valueIndex.TryGetValue(arr[lastIndex], out var sameValueIndicies))
                    {
                        foreach(int idx in sameValueIndicies.Where(i => i != lastIndex).Where(i => false == visited.Contains(i)))
                        {
                            if (idx == arr.Length - 1)
                            {
                                return pathLength + 1;
                            }

                            visited.Add(idx);
                            buffer.Enqueue(idx);
                        }
                    }

                    if(lastIndex - 1 > 0 && false == visited.Contains(lastIndex - 1))
                    {
                        visited.Add(lastIndex - 1);
                        buffer.Enqueue(lastIndex - 1);
                    }
                }
                ++pathLength;
            }

            return arr.Length - 1;
        }
    }
}
