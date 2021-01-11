using System.Collections.Generic;

namespace LeetCode.Recursion
{
    class CombineSolution
    {
        public IList<IList<int>> Combine(int n, int k)
        {
            var result = new List<IList<int>>();
            var source = new int[n];
            for(int i = 0; i < n; ++i)
            {
                source[i] = i + 1;
            }
            Append(0, source, k, new List<int>(), result);
            return result;
        }

        private static void Append(int idx, int[] source, int k, List<int> current, List<IList<int>> result)
        {
            if(current.Count == k)
            {
                result.Add(new List<int>(current));
                return;
            }

            for(int i = idx; i < source.Length; ++i)
            {
                current.Add(source[i]);
                Append(i + 1, source, k, current, result);
                current.RemoveAt(current.Count - 1);
            }
        }
    }
}
