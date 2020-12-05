using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Dynamic
{
    class CanPlaceFlowersSolution
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int current = 0;
            bool first = true;

            for(int i = 0; i < flowerbed.Length; ++i)
            {
                if(flowerbed[i] == 1)
                {
                    if(first && current > 1)
                    {
                        n -= current / 2;
                    }
                    else if(current > 2)
                    {
                        n -= (current - 1) / 2;
                    }

                    if(n <= 0)
                    {
                        return true;
                    }

                    first = false;
                    current = 0;
                }
                else
                {
                    ++current;
                }
            }

            if (first)
            {
                return ((current + 1) / 2) >= n;
            }
            else
            {
                return (current / 2) >= n;
            }
        }
    }
}
