using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.BinarySearch
{
    internal abstract class GuessGame
    {
        protected int guess(int num) => 0;
    }

    class GuessGameSolution: GuessGame
    {
        public int GuessNumber(int n)
        {
            int left = 1;
            int right = n;
            int answer = 0;
            while(left <= right)
            {
                int mid = left + (right - left) / 2;
                answer = guess(mid);
                if (answer == 0) return mid;
                if (answer > 0) left = mid + 1;
                else right = mid - 1;
            }
            return 0;
        }
    }
}
