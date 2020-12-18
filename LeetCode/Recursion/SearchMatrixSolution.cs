using System;

namespace LeetCode.Recursion
{
    class SearchMatrixSolution
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
            {
                return false;
            }

            int colUpperBound = UpperBound(matrix[0].AsSpan(), target);
            if (colUpperBound == 0) return false;
            int columnsCount = colUpperBound == -1 ? matrix[0].Length : colUpperBound;

            int rowUpperBound = UpperBound(matrix, 0, target);
            if (rowUpperBound == 0) return false;
            int rowsCount = rowUpperBound == -1 ? matrix.Length : rowUpperBound;

            for(int row = 0; row < rowsCount; ++row)
            {
                if(Search(matrix[row].AsSpan(0, columnsCount), target))
                {
                    return true;
                }
            }
            return false;
        }

        private static bool Search(Span<int> nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target) return true;
                if (target < nums[mid]) right = mid - 1;
                else left = mid + 1;
            }

            return false;
        }

        private static int UpperBound(Span<int> nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while(left <= right)
            {
                int mid = left + (right - left) / 2;
                if(nums[mid] <= target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return left < nums.Length ? left : -1;
        }

        private static int UpperBound(int[][] nums, int col, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid][col] <= target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return left < nums.Length ? left : -1;
        }
    }
}
