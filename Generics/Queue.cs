using System;

using System.Text;

namespace Generic
{
    public class Queue<T>
    {
        private Node<T> first;
        private Node<T> last;

        public Queue()
        {
            this.first = this.last = null;
        }

        public bool IsEmpty()
        {
            return this.first == null;
        }
        public void Insert(T x)
        {
            Node<T> temp = new Node<T>(x);
            if (IsEmpty())
            {
                this.first = new Node<T>(x);
                this.last = this.first;
            }
            else if (x != null)
            {

                this.last.SetNext(temp);
                this.last = this.last.GetNext();
            }
        }
        public T Remove()
        {
            T newT = this.first.GetInfo();
            this.first = this.first.GetNext();
            return newT;
        }
        public T Head()
        {
            return this.first.GetInfo();
        }
        /*public void Reverse()
        {
            Stack<T> s = new Stack<T>();
            while (!this.IsEmpty())
                s.push(this.Remove());
            while (!s.isEmpty())
                this.Insert(s.pop());
        }*/
        public override string ToString()
        {
            string str = "Queue:[ ";
            Node<T> pos = this.first;
            while (pos != null && pos.GetNext() != null)
            {
                str += pos.GetInfo() + ",";
                pos = pos.GetNext();
            }
            return str + pos + "]";
        }
    }
}
