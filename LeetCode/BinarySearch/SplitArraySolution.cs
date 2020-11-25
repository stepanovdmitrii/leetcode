using System.Linq;

namespace LeetCode.BinarySearch
{
    public sealed class SplitArraySolution
    {
        public int SplitArray(int[] nums, int m)
        {
            if (m == 1) return nums.Sum();
            Init(nums, out int left, out int right);

            while(left <= right)
            {
                int mid = left + (right - left) / 2;
                if(CanSplit(nums, mid, m))
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return left;
        }

        private static void Init(int[] nums, out int min, out int max) //min - max value in array, max - sum of items
        {
            min = max = nums[0];
            for(int i = 1; i < nums.Length; ++i)
            {
                if (nums[i] > min) min = nums[i];
                max += nums[i];
            }
        }

        private static bool CanSplit(int[] nums, int limit, int count)
        {
            int runningSum = nums[0];
            for(int idx = 1; idx < nums.Length && count > 0; ++idx)
            {
                runningSum += nums[idx];
                if(runningSum > limit)
                {
                    runningSum = nums[idx];
                    --count;
                }
            }
            return count > 0;
        }
    }
}
