using System;
using System.Text;

namespace Generic
{
    public class BinNode<T>
    {
        private BinNode<T> left;
        private T value;
        private BinNode<T> right;
        public BinNode(BinNode<T> left, T value, BinNode<T> right)
        {
            this.left = left;
            this.value = value;
            this.right = right;
        }
        public BinNode(T value)
        {
            this.value = value;
            this.right = null;
            this.left = null;
        }
        public BinNode<T> GetLeft()
        {
            return left;
        }
        public void SetLeft(BinNode<T> left)
        {
            this.left = left;
        }
        public T GetValue()
        {
            return value;
        }
        public void SetValue(T value)
        {
            this.value = value;
        }
        public BinNode<T> GetRight()
        {
            return right;
        }
        public void SetRight(BinNode<T> right)
        {
            this.right = right;
        }
        public bool HasLeft() // find left
        {
            return this.left != null;
        }
        public bool HasRight() // find right
        {
            return this.right != null;
        }
        public override string ToString() // To String
        {
            return " " + this.value;
        }

        /*/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\//\/\|
        |//////////////////////////////////////////////////////|
        |//////////////////////////////////////////////////////|
        |/////        \////////         \////|     \////    |//////|
        |////|         \//////|         /////|      \///    |//////|
        |////|   ///\   \/////|     /////////|       \//    |//////|
        |////|   ///    //////|         /////|        \/    |//////|
        |////|        ////////|         /////|    /\        |//////|
        |////|   ///    \/////|     /////////|    //\       |//////|
        |////|   ///      \///|         /////|    ///\      |//////|
        |////|___________/////|_________/////|____////\_____|//////|
        |//////////////////////////////////////////////////////|
        |//////////////////////////////////////////////////////|
        |/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\//\/\|*/

    }

}