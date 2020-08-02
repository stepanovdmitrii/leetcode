using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Strings;
using NUnit.Framework;

namespace LeetCode.UnitTests
{
    [TestFixture]
    public class LongestCommonPrefixTests
    {
        [Test]
        public void Test()
        {
            var solution = new LongestCommonPrefixSolution();
            Assert.AreEqual("fl", solution.LongestCommonPrefix(new[] { "flower", "flow", "flight" }));
            Assert.AreEqual("", solution.LongestCommonPrefix(new[] { "dog", "racecar", "car" }));
        }
    }
}
