using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Arrays;
using NUnit.Framework;

namespace LeetCode.UnitTests
{
    [TestFixture]
    public class NumPairsDivisibleBy60SolutionTests
    {
        [Test]
        public void Test_Case15()
        {
            var arr = new int[]
            {
                418, 204, 77, 278, 239, 457, 284, 263, 372, 279, 476, 416, 360, 18
            };
            var solution = new NumPairsDivisibleBy60Solution();
            Assert.AreEqual(1, solution.NumPairsDivisibleBy60(arr));

        }
    }
}
