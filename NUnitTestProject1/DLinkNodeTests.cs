using CSharp;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1
{
    public class DLinkNodeTests
    {
        private DLinkNode node1, node2, node3, node4;

        [SetUp]
        public void SetUp()
        {
            node1 = new DLinkNode();
            node2 = new DLinkNode();
            node3 = new DLinkNode();
            node4 = new DLinkNode();

            node1.Next = node2;
            node2.Previous = node1;
            node2.Next = node3;


            //node1.AddAfter(node2);
            //node2.AddAfter(node3);
            //node2.AddAfter(node4);
        }


        [Test]
        public void AddTest()
        {
            //SetUp();

            // 1 [2]
            Assert.IsNull(node1.Previous);
            Assert.AreEqual(node2, node1.Next);

            Assert.AreEqual(node1, node2.Previous);
            Assert.IsNull(node2.Next);


            // 1 2 [3]
            Assert.IsNull(node3.Next);
            Assert.AreEqual(node2, node3.Previous);
            Assert.AreEqual(node3, node2.Next);


            //1 2 [4] 3
            Assert.AreEqual(node4, node2.Next);
            Assert.AreEqual(node2, node4.Previous);
            Assert.AreEqual(node3, node4.Next);
            Assert.AreEqual(node4, node3.Previous);
            Assert.IsNull(node3.Next);
        }

        [Test]
        public void DeleteTest()
        {
            //SetUp();
            //1 2 [3] 4 5


        }


        [Test]
        public void SwapTest()
        {
            //1 [2] 3 [4] 5
        }
    }
}
