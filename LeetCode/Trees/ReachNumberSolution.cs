namespace LeetCode.Trees
{
    class ReachNumberSolution
    {
        public int ReachNumber(int target)
        {
            int left = System.Math.Abs(target);
            int part = 0;
            while (left > 0)
            {
                ++part;
                left -= part;
            }
            return left % 2 == 0 ? part : part + 1 + part % 2;
        }
    }
}
