namespace LeetCode.Strings
{
    class ReverseStringSolution
    {
        public void ReverseString(char[] s)
        {
            if (s.Length <= 1) return;

            int left = 0;
            int right = s.Length - 1;
            while(left < right)
            {
                Swap(ref s[left], ref s[right]);
                ++left;
                --right;
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
