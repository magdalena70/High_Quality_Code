using System;
using System.Collections.Generic;

namespace Tree
{
    public class Tree<T> : ITree<T>
    {
        public Tree()
        {
            this.Root = null;
        }

        public Tree(ITreeNode<T> node) // by reference
        {
            this.Root = node;
        }

        public Tree(T value)
        {
            this.Root = new TreeNode<T>(value);
        }

        public ITreeNode<T> Root { get; set; }
    }
}
