using System;
using System.Text;

namespace Generic
{

    public class List<T>
    {
        private Node<T> first;

        public List()
        {
            this.first = null;
        }
        public bool IsEmpty()
        {
            return this.first == null;
        }
        public Node<T> GetFirst()
        {
            return this.first;
        }
        public Node<T> Insert(Node<T> pos, T x)
        {
            Node<T> temp = new Node<T>(x);
            if (pos == null)
            {
                temp.SetNext(this.first);
                this.first = temp;
            }
            else
            {
                temp.SetNext(pos.GetNext());
                pos.SetNext(temp);
            }
            return temp;
        }
        public Node<T> Remove(Node<T> pos)
        {
            if (this.first == pos) { this.first = pos.GetNext(); }

            else
            {
                Node<T> prevPos = this.GetFirst();
                while (prevPos.GetNext() != null)
                    prevPos = prevPos.GetNext();
                prevPos.SetNext(pos.GetNext());
            }
            Node<T> nextPos = pos.GetNext();
            pos.SetNext(null);

            return nextPos;
        }
        public override string ToString() // ToString not in mahat!!!!!!!
        {
            if (this.first == null) return "[empty list]";
            string s = "list: first-->[";
            Node<T> tostring = this.first;
            while (tostring != null)
            {
                s += tostring.GetInfo();
                tostring = tostring.GetNext();
                s += tostring == null ? "" : "-->";
            }
            s += ']';
            return s;
        }
    }
}