namespace LeetCode.BinarySearch
{
    public sealed class RangeSearchSolution
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int lowerBound = LowerBound(nums, target);
            if(lowerBound == -1 || nums[lowerBound] > target) return new[] { -1, -1};

            int upperBound = UpperBound(nums, target);
            if (upperBound == -1) return new[] { lowerBound, nums.Length - 1 };
            return new[] { lowerBound, upperBound - 1 };
        }

        private int LowerBound(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] < target)
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

        private int UpperBound(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            while(left <= right)
            {
                int mid = left + (right - left) / 2;
                if(nums[mid] <= target )
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
