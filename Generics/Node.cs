using System;
using System.Text;

namespace Generic
{
    public class Node<T>
    {
        private T info;
        private Node<T> next;
        public Node(T info)
        {
            this.info = info;
            this.next = null;
        }
        public Node(T info, Node<T> next)
        {
            this.info = info;
            this.next = next;
        }
        public void Setinfo(T info) { this.info = info; }
        public void SetNext(Node<T> next) { this.next = next; }
        public T GetInfo() { return this.info; }
        public Node<T> GetNext() { return this.next; }
        public string printAllNexts()
        {
            string s = "chin-->" + this.GetInfo() + "-->";
            if (this.GetNext() == null) return s;
            Node<T> temp = new Node<T>(this.GetNext().GetInfo(), this.GetNext().GetNext());
            while (temp != null)
            {
                s += temp.GetInfo() + "-->";
                temp = temp.GetNext();
            }
            s += "null";
            return s;
        }
        public override string ToString()
        {
            return this.info;
        }
    }// ________ Generic Node<T> class ________ //


  

}

