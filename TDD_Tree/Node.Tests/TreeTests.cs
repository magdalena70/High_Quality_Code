using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tree;

namespace Node.Tests
{
    [TestClass]
    public class TreeTests
    {
        [TestMethod]
        public void TestCreateTreeWithIntegerRoot()
        {
            ITree<int> tree = new Tree.Tree<int>(5);
            Assert.AreEqual(5, tree.Root.Value);
            Assert.IsNotNull(tree.Root);
        }

        [TestMethod]
        public void TestCreateTreeWithEmptyRoot()
        {
            ITree<int> tree = new Tree.Tree<int>();
            Assert.IsNull(tree.Root);
        }

        [TestMethod]
        public void TestCreateTreeWithRootByReference()
        {
            ITreeNode<int> node = new TreeNode<int>(5);

            ITree<int> tree = new Tree.Tree<int>(node);
            Assert.AreSame(node, tree.Root);
        }

        [TestMethod]
        public void TestCreateTreeWithChildrenNodes()
        {
            var nodes = new List<ITreeNode<int>>();
            for (int i = 0; i < 10; i++)
            {
                nodes.Add(new TreeNode<int>(i * 5)); 
            }

            ITree<int> tree = new Tree.Tree<int>(0);
            tree.Root.Children = nodes;
            Assert.AreEqual(10, tree.Root.Children.Count());
        }

        [TestMethod]
        public void TestCheckTreeChildrenNodeValues()
        {
            var nodes = new List<ITreeNode<int>>();
            for (int i = 0; i < 10; i++)
            {
                nodes.Add(new TreeNode<int>(i * 5));
            }

            ITree<int> tree = new Tree.Tree<int>(0);
            tree.Root.Children = nodes;
            Assert.AreEqual(0, tree.Root.Children.First().Value); // first
            Assert.AreEqual(5, tree.Root.Children.Skip(1).First().Value); // second
        }

        [TestMethod]
        public void TestTreeChildrenInDepth()
        {
            ITree<int> tree = new Tree<int>(0);
            tree.Root.Children.Add(new TreeNode<int>(5));
            var node = tree.Root.Children.First();
            node.Children.Add(new TreeNode<int>(10));

            Assert.AreEqual(0, tree.Root.Value);
            Assert.AreEqual(1, tree.Root.Children.Count());

            Assert.AreEqual(5, node.Value);
            Assert.AreEqual(1, node.Children.Count());

            Assert.AreEqual(10, node.Children.First().Value);
        }
    }
}
