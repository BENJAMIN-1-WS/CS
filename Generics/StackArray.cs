using System;
using System.Text;

namespace Generic
{
    public class StackArray<T>
    {
        public const int MAX = 10;
        private int pos;
        private T[] data;
        public StackArray()
        {
            this.pos = -1;
            data = new T[MAX];
        }
        public bool IsEmpty()
        {
            return this.pos == -1;
        }
        public void Push(T x)
        {
            this.data[++this.pos] = x;
        }
        public T Top()
        {
            return this.data[this.pos];
        }
        public T Pop()
        {
            T temp = this.data[this.pos--];
            return temp;
        }
        public override string ToString()
        {
            if (this.pos == -1)
                return "empty Stack";
            string str = "Stack :[";
            for (int i = this.pos; i > 0; i--)
                str += this.data[i] + "|";
            str += this.data[0] + "]";
            return str;
        }
    }
}
