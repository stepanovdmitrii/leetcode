namespace LeetCode.BinarySearch
{
    class FindDuplicateNumberSolution
    {
        public int FindDuplicate(int[] nums)
        {
            bool[] helper = new bool[nums.Length];
            foreach(var num in nums)
            {
                if(helper[num - 1])
                {
                    return num;
                }
                else
                {
                    helper[num - 1] = true;
                }
            }
            return 0;
        }
    }
}
