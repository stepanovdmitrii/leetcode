namespace LeetCode.Arrays
{
    class PlusOneSolution
    {
        public int[] PlusOne(int[] digits)
        {
            bool overflow = false;
            for(int i = digits.Length - 1; i >= 0; --i)
            {
                digits[i] += 1;
                if(digits[i] < 10)
                {
                    overflow = false;
                    break;
                }
                else
                {
                    overflow = true;
                    digits[i] = digits[i] % 10;
                }
            }
            if (overflow)
            {
                var result = new int[digits.Length + 1];
                result[0] = 1;
                for(int i = 1; i < result.Length; ++i)
                {
                    result[i] = digits[i - 1];
                }
                return result;
            }
            return digits;
        }
    }
}
