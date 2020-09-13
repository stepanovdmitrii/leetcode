using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace LeetCode.Arrays
{
    class SortArrayByParitySolution
    {
        public int[] SortArrayByParity(int[] A)
        {
            Array.Sort(A, new ParityComparer());
            return A;
        }

        private sealed class ParityComparer : IComparer<int>
        {
            public int Compare([AllowNull] int x, [AllowNull] int y)
            {
                return (x % 2).CompareTo(y % 2);
            }
        }
    }
}
