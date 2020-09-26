using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.LinkedList;
using NUnit.Framework;

namespace LeetCode.UnitTests
{
    [TestFixture]
    public sealed class LinkedListTests
    {
        [Test]
        public void Test1()
        {
            var list = new MyLinkedList();
            list.AddAtHead(1);
            list.AddAtTail(3);
            list.AddAtIndex(1, 2);
            Assert.AreEqual(2, list.Get(1));
            list.DeleteAtIndex(1);
            Assert.AreEqual(3, list.Get(1));
        }

        [Test]
        public void Test2()
        {
            var list = new MyLinkedList();
            list.AddAtHead(1);
            list.AddAtTail(3);
            list.AddAtIndex(1, 2);
            Assert.AreEqual(1, list.Get(0));
            list.DeleteAtIndex(0);
            Assert.AreEqual(2, list.Get(0));
        }
    }
}
