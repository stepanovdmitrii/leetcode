using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace LeetCode.Queue
{
    class NumIslandsSolution
    {
        struct Index
        {
            public int Row;
            public int Column;
        }

        class Comparer : IEqualityComparer<Index>
        {
            public bool Equals(Index x, Index y)
            {
                return x.Row == y.Row && x.Column == y.Column;
            }

            public int GetHashCode(Index obj)
            {
                return HashCode.Combine<int, int>(obj.Row, obj.Column);
            }
        }

        public int NumIslands(char[][] grid)
        {

        }
    }
}
