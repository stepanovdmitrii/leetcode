using System.Collections.Generic;

namespace LeetCode.Recursion
{
    class PascalsTriangleSolution
    {
        public IList<int> GetRow(int rowIndex)
        {
            if (rowIndex == 0) return new List<int> { 1 };
            var previous = GetRow(rowIndex - 1);
            var result = new List<int>(rowIndex + 1);
            for (int i = 0; i < rowIndex + 1; ++i) result.Add(0);
            result[0] = result[rowIndex] = 1;
            for (int idx = 1; idx < rowIndex; ++idx)
            {
                result[idx] = previous[idx - 1] + previous[idx];
            }
            return result;
        }
    }
}
