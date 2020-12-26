using System;
using System.Linq;
using LeetCode.Arrays;
using NUnit.Framework;

namespace LeetCode.UnitTests
{
    [TestFixture]
    public sealed class FindDiagonalOrderTests
    {
        [Test]
        public void TestCase0()
        {
            var solution = new FindDiagonalOrderSolution();
            var result = solution.FindDiagonalOrder(new int[][] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } });
            Assert.IsTrue(result.SequenceEqual(new[] { 1, 2, 4, 7, 5, 3, 6, 8, 9 }));
        }
    }
}
