using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Arrays
{
    class ValidMountainArraySolution
    {
        public bool ValidMountainArray(int[] A)
        {
            if (A.Length < 3) return false;

            bool asc = true;
            int prev = A[0];
            for(int i = 1; i < A.Length; ++i)
            {
                if((asc && A[i] > prev) || (!asc && A[i] < prev))
                {
                    prev = A[i];
                    continue;
                }

                if(asc && A[i] < prev && i != 1)
                {
                    prev = A[i];
                    asc = false;
                    continue;
                }

                return false;
            }

            return asc == false;
        }
    }
}
