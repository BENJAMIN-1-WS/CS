using System;

using System.Text;

namespace Generic
{
    public class Stack<T>
    {
        private Node<T> first;

        public Stack()
        {
            this.first = null;
        }
        public bool isEmpty()
        {
            return this.first == null;
        }
        public void push(T x)
        {
            this.first = new Node<T>(x, this.first);
        }
        public T pop()
        {
            T x = this.first.GetInfo();
            this.first = this.first.GetNext();
            return x;
        }
        public override string ToString()
        {
            string str = "[";
            Node<T> pos = this.first;
            while (pos != null)
            {
                str += pos.GetInfo();
                if (pos.GetNext() != null)
                    str += ",";
                pos = pos.GetNext();
            }
            str += "]";
            return str;
        }
    }
}
