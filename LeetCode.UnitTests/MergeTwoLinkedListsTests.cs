using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.LinkedList;
using NUnit.Framework;

namespace LeetCode.UnitTests
{
    [TestFixture]
    class MergeTwoLinkedListsTests
    {
        [Test]
        public void Test()
        {
            var l1 = Create(new[] { 1, 2, 4 });
            var l2 = Create(new[] { 1, 3, 4 });
            var merged = new MergeTwoListsSolution().MergeTwoLists(l1, l2);
        }

        private ListNode Create(int[] values)
        {
            ListNode next = null;
            for(int i = values.Length - 1; i >= 0; --i)
            {
                ListNode node = new ListNode(values[i]);
                node.next = next;
                next = node;
            }
            return next;
        }
    }
}
