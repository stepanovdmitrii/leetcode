using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.BinarySearch
{
    public sealed class ConclusionSolutions
    {
        public double MyPow(double x, int n)
        {
            double temp;

            if (n == 0) return 1;

            temp = MyPow(x, n / 2);

            if (n % 2 == 0)
            {
                return temp * temp;
            }
            else if (n > 0)
            {
                return x * temp * temp;
            }
            else
            {
                return (temp * temp) / x;
            }
        }

        public bool IsPerfectSquare(int num)
        {
            if (num < 1) return false;
            if (num == 1) return true;
            int left = 1;
            int right = num / 2 < 46340 ? num / 2 : 46340;
            while(left <= right)
            {
                int mid = left + (right - left) / 2;
                int value = mid * mid;
                if (value == num) return true;
                if(value > num)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return false;
        }
        public char NextGreatestLetter(char[] letters, char target)
        {
            int left = 0;
            int right = letters.Length - 1;
            while(left <= right)
            {
                int mid = left + (right - left) / 2;
                if (target >= letters[mid])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return letters[left % letters.Length];
        }
    }
}
