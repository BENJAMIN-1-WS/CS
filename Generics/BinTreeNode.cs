using System;

using System.Text;

namespace Generic
{
    public class BinTreeNode<T>
    {
        private BinTreeNode<T> left;
        private T info;
        private BinTreeNode<T> right;

        public BinTreeNode(T x)
        {
            this.left = null;
            this.right = null;
            this.info = x;
        }
        public BinTreeNode(BinTreeNode<T> left, T x, BinTreeNode<T> right)
        {
            this.left = left;
            this.right = right;
            this.info = x;
        }
        public T getInfo()
        {
            return info;
        }
        public BinTreeNode<T> getRight()
        {
            return right;
        }
        public BinTreeNode<T> getLeft()
        {
            return left;
        }
        public void setRight(BinTreeNode<T> right)
        {
            this.right = right;
        }
        public void setleft(BinTreeNode<T> left)
        {
            this.left = left;
        }
        public override string ToString()
        {
            return info.ToString();
        }
    }
}
