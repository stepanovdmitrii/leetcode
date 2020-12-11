using LeetCode.Arrays;
using LeetCode.RemoveDuplicatesFromSortedArray;
using NUnit.Framework;

namespace LeetCode.UnitTests
{
    [TestFixture]
    public sealed class RemoveDuplicatesFromSortedArrayTests
    {
        [Test]
        public void Test()
        {
            var solution = new Solution();
            var nums = new[] { 0, 0, 1, 1, 2, 2, 3, 3, 3 };
            Assert.AreEqual(4, solution.RemoveDuplicates(nums));
            nums = new[] { 1, 2 };
            Assert.AreEqual(2, solution.RemoveDuplicates(nums));
        }

        [Test]
        public void Test2_Example1()
        {
            var solution = new RemoveDuplicates2Solution();
            var nums = new[] { 1, 1, 1, 2, 2, 3 };
            var actual = solution.RemoveDuplicates(nums);
            Assert.AreEqual(5, actual);
        }

        [Test]
        public void Test2_Example2()
        {
            var solution = new RemoveDuplicates2Solution();
            var nums = new[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 };
            var actual = solution.RemoveDuplicates(nums);
            Assert.AreEqual(7, actual);
        }

        [Test]
        public void Test2_Case53()
        {
            var solution = new RemoveDuplicates2Solution();
            var nums = new[] { 1, 1, 1, 2, 2, 2, 3, 3 };
            var actual = solution.RemoveDuplicates(nums);
            Assert.AreEqual(6, actual);
        }

        [Test]
        public void Test2_Case101()
        {
            var solution = new RemoveDuplicates2Solution();
            var nums = new[] { 1, 1, 2, 2 };
            var actual = solution.RemoveDuplicates(nums);
            Assert.AreEqual(4, actual);
        }
    }
}
