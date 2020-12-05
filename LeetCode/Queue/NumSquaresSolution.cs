using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Queue
{
    class NumSquaresSolution
    {
        public int NumSquares(int n)
        {
            int max = (int)System.Math.Sqrt(n);
            var squares = new int[max];
            for(int i = 0; i < squares.Length; ++i)
            {
                squares[i] = (i + 1) * (i + 1);
            }


            int result = 0;
            var batch = new Queue<int>();
            batch.Enqueue(n);
            while(batch.Count > 0)
            {
                ++result;

                int count = batch.Count;
                for(int i = 0; i < count; ++i)
                {
                    int current = batch.Dequeue();
                    foreach(int square in squares)
                    {
                        int left = current - square;
                        if (left == 0) return result;
                        if (left > 0) batch.Enqueue(left);
                    }
                }
            }


            return result;
        }
    }
}
