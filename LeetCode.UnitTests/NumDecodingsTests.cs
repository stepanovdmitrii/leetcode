using LeetCode.Recursion;
using NUnit.Framework;

namespace LeetCode.UnitTests
{
    [TestFixture]
    public sealed class NumDecodingsTests
    {
        [Test]
        public void TestCase0()
        {
            var solution = new DecodeWaysSoltion();
            Assert.That(solution.NumDecodings("12"), Is.EqualTo(2));
        }

        [Test]
        public void TestCase16()
        {
            var solution = new DecodeWaysSoltion();
            Assert.That(solution.NumDecodings("2101"), Is.EqualTo(1));
        }

        [Test]
        public void TestCase228()
        {
            var solution = new DecodeWaysSoltion();
            Assert.That(solution.NumDecodings("1123"), Is.EqualTo(5));
        }
    }
}
