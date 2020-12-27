using LeetCode.Trees;
using NUnit.Framework;

namespace LeetCode.UnitTests.Trees
{
    [TestFixture]
    public sealed class JumpGame4SolutionTests
    {
        [Test]
        public void TestCase22()
        {
            var solution = new JumpGame4Solution();
            Assert.That(solution.MinJumps(new[] { 100, -23, -23, 404, 100, 23, 23, 23, 3, 404 }), Is.EqualTo(3));
        }

    }
}
