/*using System;

using System.Text;

namespace Generic
{
    public class P_9
    {
        public static bool p9q5(List<int> lst1, int x)
        {
            bool res;
            int tem;
            if (lst1.isEmpty())
                res = false;
            else
            {
                tem = lst1.getFirst().getInfo();
                lst1.remove(lst1.getFirst());
                res = (tem == x) || p9q5(lst1, x);
                lst1.Insert(null, tem);
            }
            return res;
        }
        // The sum of the double places
        public static int p9_q7(List<int> ls1)
        {
            int counter = 1, sum = 0;
            Node<int> pos = ls1.getFirst();
            while (pos!= null)
            {
                if (counter % 2 == 0)
                    sum += pos.getInfo();
                pos = pos.getNext();
                counter++;
            }
            return sum;
        }
        // Is the list in alphabetical order
        public static bool p9_q8(List<string> ls1)
        {
            Node<string> pos = ls1.getFirst();

            while (pos.getNext()!= null)
            {/// a d

                if (pos.getInfo().CompareTo(pos.getNext().getInfo()) > 0)
                    return false;
                pos = pos.getNext();
            }
            return true;
        }
        // Returns a list of the sum of the organs in the same location

        public static List<char> p9_q9(List<char> ls1) // k t k t y e r r k k k k t t t
        {
            Node<char> h = ls1.getFirst(); // -> k
            Node<char> pos;
            Node<char> befor_pos;
            while (h!= null && h.getNext()!= null)
            {
                befor_pos = h;
                pos = h.getNext();
                while (pos!= null)
                {
                    if (h.getInfo() == pos.getInfo())
                    {
                        befor_pos.setNext(pos.getNext());
                        Node<char> z = pos;
                        z.setNext(null);
                        pos = befor_pos.getNext();
                    }
                    else
                    {
                        befor_pos = befor_pos.getNext();
                        pos = pos.getNext();
                    }
                }
                h = h.getNext();
            }
            return ls1;
        }

        public static List<int> p9_q11(List<int> ls1, List<int> ls2)
        {
            List<int> new_list = new List<int>();
            Node<int> pos1 = ls1.getFirst();
            Node<int> pos2 = ls2.getFirst();
            int sum = pos1.getInfo() + pos2.getInfo();
            // new_list.setFirst (new Node <int> (sum));
            pos1 = pos1.getNext();
            pos2 = pos2.getNext();
            Node<int> pos3 = new_list.getFirst();

            while (pos1!= null && pos2!= null)
            {
                sum = pos1.getInfo() + pos2.getInfo();
                pos3.setNext(new Node<int>(sum));
                pos1 = pos1.getNext();
                pos2 = pos2.getNext();
                pos3 = pos3.getNext();
            }

            if (pos1! == null)
                pos3.setNext(pos1);
            if (pos2! == null)
                pos3.setNext(pos2);
            return new_list;
        }
        // merges in order two sorted lists
        public static List<int> p9_q12(List<int> ls1, List<int> ls2)
        {
            Node<int> pos1 = ls1.getFirst();
            Node<int> pos2 = ls2.getFirst();
            Node<int> pos3;
            List<int> newlis3 = new List<int>();
            if (pos1.getInfo() < pos2.getInfo())
            {
                // newlis3.setFirst (pos1);
                pos3 = newlis3.getFirst();
                pos1 = pos1.getNext();
            }
            else
            {
                // newlis3.setFirst (pos2);
                pos3 = newlis3.getFirst();
                pos2 = pos2.getNext();
            }

            while (pos1! == null && pos2! == null)
            {
                if (pos1.getInfo() < pos2.getInfo())
                {
                    pos3.setNext(pos1);
                    pos3 = pos3.getNext();
                    pos1 = pos1.getNext();

                }
                else
                {
                    pos3.setNext(pos2);
                    pos3 = pos3.getNext();
                    pos2 = pos2.getNext();
                }
            }
            Node<int> x = pos1!= null ? pos1 : pos2;
            pos3.setNext(x);
            return newlis3;
        }
    }
}*/