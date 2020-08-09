using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.SortingAndSearching
{
    abstract class VersionControl
    {
        protected bool IsBadVersion(int version) => DateTime.UtcNow.Ticks % 2 == 0;
    }
    class FirstBadVersionSolution: VersionControl
    {
        public int FirstBadVersion(int n)
        {
            int l = 0;
            int r = n - 1;
            while(l <= r)
            {
                int mid = l + (r - l) / 2;
                if(IsBadVersion(mid + 1))
                {
                    r = mid - 1;
                }
                else
                {
                    l = mid + 1;
                }
            }
            return l + 1;
        }
    }
}
