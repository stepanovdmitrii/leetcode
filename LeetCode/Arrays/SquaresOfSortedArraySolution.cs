using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Arrays
{
    class SquaresOfSortedArraySolution
    {
        public int[] SortedSquares(int[] A)
        {
            var result = new int[A.Length];
            int left = 0;
            int right = A.Length - 1;
            int index = result.Length - 1;
            while(left <= right)
            {
                if( System.Math.Abs(A[left]) >= System.Math.Abs(A[right]))
                {
                    result[index] = A[left] * A[left];
                    ++left;
                }
                else
                {
                    result[index] = A[right] * A[right];
                    --right;
                }
                --index;
            }

            return result;
        }
    }
}
