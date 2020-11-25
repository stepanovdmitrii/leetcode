using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using LeetCode.BinarySearch;

namespace LeetCode.UnitTests
{
    [TestFixture]
    public sealed class BinarySearchTests
    {
        [Test]
        public void MySqrtTests()
        {
            var solution = new MySqrtSolution();
            Assert.AreEqual(46339, solution.MySqrt(2147395599));
        }

        [Test]
        public void SearchSortedPivotTests()
        {
            var solution = new SortedPivotSearchSolution();
            Assert.AreEqual(1, solution.Search(new[] { 3, 1 }, 1));
        }

        [Test]
        public void IsPerfectSquareTests()
        {
            var solution = new ConclusionSolutions();
            Assert.IsTrue(solution.IsPerfectSquare(16));
            Assert.IsFalse(solution.IsPerfectSquare(14));
            Assert.IsTrue(solution.IsPerfectSquare(9));
        }

        [Test]
        public void SmallestDistancePairTests()
        {
            var solution = new SmallestDistancePairSolution();
            Assert.AreEqual(5, solution.SmallestDistancePair(new[] { 1, 6, 1 }, 3));
        }
    }
}
