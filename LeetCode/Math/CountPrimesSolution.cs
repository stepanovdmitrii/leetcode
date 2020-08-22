using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Math
{
    class CountPrimesSolution
    {
        public int CountPrimes(int n)
        {
            if (n < 2) return 0;

            var count = n - 2;
            var primes = new bool[n];
            for (int i = 2; i <= System.Math.Sqrt(n); i++)
            {
                if (false == primes[i]) //is prime
                {
                    for (int j = i * i; j < n; j += i)
                    {
                        if (false == primes[j]) //is prime
                        {
                            primes[j] = true; //is not prime
                            count--;
                        }
                    }
                }
            }

            return count;
        }
    }
}
