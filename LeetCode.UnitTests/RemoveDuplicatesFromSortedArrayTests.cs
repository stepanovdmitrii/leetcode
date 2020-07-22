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
    }
}
