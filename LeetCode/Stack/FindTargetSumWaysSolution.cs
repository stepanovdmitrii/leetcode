using System.Linq;

namespace LeetCode.Stack
{
    class FindTargetSumWaysSolution
    {
        public int FindTargetSumWays(int[] nums, int S)
        {
            var total = nums.Sum();

            if (S > total)
                return 0;

            var adjSum = total + S;
            if (adjSum % 2 == 1)
                return 0;

            int count = 0;
            Process(0, S, 0, nums, 1, ref count);
            Process(0, S, 0, nums, -1, ref count);
            return count;
        }

        private void Process(int current, int target, int idx, int[] nums, int mult, ref int count)
        {
            if(idx == nums.Length - 1)
            {
                if(current + mult * nums[idx] == target) ++count;
                return;
            }

            Process(current + mult * nums[idx], target, idx + 1, nums, 1, ref count);
            Process(current + mult * nums[idx], target, idx + 1, nums, -1, ref count);
        }
    }
}
