using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tree;
using System.Text;
using System.Collections.Generic;

namespace Node.Tests
{
    [TestClass]
    public class NodeTests
    {
        [TestMethod]
        public void TestCreateEmptyNode()
        {
            ITreeNode<int> node = new TreeNode<int>(5);
            Assert.AreEqual(5, node.Value);
            Assert.IsNotNull(node.Children);
        }

        [TestMethod]
        public void TestCreateEmptyNodeWithObject()
        {
            ITreeNode<StringBuilder> node = new TreeNode<StringBuilder>();
            Assert.IsNull(node.Value);
            Assert.IsNotNull(node.Children);
        }

        [TestMethod]
        public void TestCreateNonEmptyNodeWithObject()
        {
            var stringBuilder = new StringBuilder();

            ITreeNode<StringBuilder> node = 
                new TreeNode<StringBuilder>(stringBuilder);
            Assert.AreSame(stringBuilder, node.Value);
        }

        [TestMethod]
        public void TestCreateNonEmptyNodeWithCollection()
        {
            var collection = new LinkedList<int>();

            ITreeNode<LinkedList<int>> node =
                new TreeNode<LinkedList<int>>(collection);
            Assert.AreSame(collection, node.Value);
        }
    }
}
