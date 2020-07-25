using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Arrays
{
    public class RotateImageSolution
    {
        public void Rotate(int[][] matrix)
        {
            Transpon(matrix);
            ReverseByRow(matrix);
        }

        private void Transpon(int[][] matrix)
        {
            for(int row = 0; row < matrix.Length; ++row)
            {
                for(int col = row; col < matrix.Length; ++col)
                {
                    Swap(ref matrix[row][col], ref matrix[col][row]);
                }
            }
        }

        private void ReverseByRow(int[][] matrix)
        {
            for(int row = 0; row < matrix.Length; ++row)
            {
                int left = 0;
                int right = matrix.Length - 1;
                while(left < right)
                {
                    Swap(ref matrix[row][left], ref matrix[row][right]);
                    left++;
                    right--;
                }
            }
        }

        private void Swap<T>(ref T left, ref T right)
        {
            T tmp = left;
            left = right;
            right = tmp;
        }
    }
}
