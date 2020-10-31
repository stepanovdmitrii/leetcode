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

    }
}
