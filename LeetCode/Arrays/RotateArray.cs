namespace LeetCode
{
    public sealed class RotateArray
    {
        public void Rotate(int[] nums, int k)
        {
            if (k == 0 || nums.Length <= 1) return;

            k = k % nums.Length;

            Reverse(nums, 0, nums.Length - 1);
            Reverse(nums, 0, k - 1);
            Reverse(nums, k, nums.Length - 1);
        }

        private void Reverse(int[] num, int first, int last)
        {
            int temp;
            while(first < last)
            {
                temp = num[first];
                num[first] = num[last];
                num[last] = temp;

                ++first;
                --last;
            }
        }
    }
}
