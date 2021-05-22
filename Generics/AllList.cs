using System;

using System.Text;

namespace Generic
{
    public class AllList
    {
        private Node<int> list;
        private int max = 0;
        private AllList next;

        public AllList()
        {
            list = null;
            next = null;
        }
        public Node<int> getFirst()
        {
            return this.list;
        }
        public int getMax()
        {
            return max;
        }
        public AllList getNextList()
        {
            return next;
        }
        public void setMax(int x)
        {
            max = x;
        }
        public void setNextList(AllList nextList)
        {
            this.next = nextList;
        }
    }
}
