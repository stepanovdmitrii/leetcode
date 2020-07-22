namespace LeetCode.RemoveDuplicatesFromSortedArray
{
    public sealed class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length <= 1) return nums.Length;

            int current = 0;
            for(int next = current + 1; next < nums.Length; ++next)
            {
                if(nums[current] != nums[next] && ++current != next)
                {
                    nums[current] = nums[next];
                }
            }

            return current + 1;
        }
    }
}
