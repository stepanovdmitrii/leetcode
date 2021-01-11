using LeetCode.Recursion;
using NUnit.Framework;

namespace LeetCode.UnitTests.Recursion
{
    [TestFixture]
    public sealed class TotalNQueensTests
    {
        [Test]
        public void TestCase4()
        {
            var soltion = new TotalNQueensSolution();
            Assert.That(soltion.TotalNQueens(4), Is.EqualTo(2));
        }
    }
}
