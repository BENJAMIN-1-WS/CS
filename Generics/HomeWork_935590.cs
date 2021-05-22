using System;
using System.Text;

namespace Generic
{
    public class HomeWork_935590
    {
        public static Queue<int> q_7_1(Node<Node<int>> lst)
        {
            Node<int> pos;
            Queue<int> q = new Queue<int>();
            while (lst != null)
            {
                pos = lst.GetInfo();
                while (pos.GetNext() != null) pos = pos.GetNext();
                q.Insert(pos.GetInfo());
                Console.WriteLine(pos.GetInfo());
                lst = lst.GetNext();
            }
            return q;
        }

        public static int rev(string s)
        {
            string news = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                news += s[i];
            }
            int r = Int32.Parse(news);
            return r;
        }

        public static int q_7_2(Node<Node<int>> lst)
        {
            int big = 0;
            Node<Node<int>> pos1 = lst;
            int arrIntLen = 0, inx = 0;
            string str = "";
            Node<int> pos;
            while (pos1 != null)
            {
                arrIntLen++;
                pos1 = pos1.GetNext();
            }
            int[] numbers_to_result = new int[arrIntLen];

            while (lst != null)
            {
                pos = lst.GetInfo();
                while (pos != null)
                {
                    str += pos.GetInfo();
                    pos = pos.GetNext();
                }
                numbers_to_result[inx++] = rev(str);
                str = "";
                lst = lst.GetNext();
            }
            for (int i = 0; i < numbers_to_result.Length; i++)
            {
                if (big < numbers_to_result[i]) { big = numbers_to_result[i]; }
            }

            return big;
        }
        public static bool What(BinNode<int> chain, double num)
        {
            int temp = 0, c = 0;
            BinNode<int> ptr2 = chain;
            while (ptr2.GetRight() != null)
            {
                temp += ptr2.GetValue();
                ptr2 = ptr2.GetRight();
                c++;
            }
            temp += ptr2.GetValue();
            c++;
            double x = temp / (double)c;
            BinNode<int> ptr1 = chain;
            while (ptr1.GetLeft() != ptr2)
            {
                if (x == num)
                {
                    Console.WriteLine(ptr1.GetValue() + " --- " + ptr2.GetValue()); // 4---11
                    return true;
                }
                if (x < num)
                {
                    temp -= ptr1.GetValue();
                    ptr1 = ptr1.GetRight();
                }
                else
                {
                    temp -= ptr2.GetValue();
                    ptr2 = ptr2.GetLeft();
                }
                c--;
                x = (double)temp / c;
            }
            Console.WriteLine("No positive result");
            return false;
        }

        public static void _main()
        {
             Node<int> n1 = new Node<int>(2, new Node<int>(6));
             Node<int> n2 = new Node<int>(7, new Node<int>(2, new Node<int>(4)));
             Node<int> n3 = new Node<int>(8, new Node<int>(2));
             Node<int> n4 = new Node<int>(1, new Node<int>(6, new Node<int>(9)));
             Node<Node<int>> lst = new Node<Node<int>>(n1, new Node<Node<int>>(n2, new Node<Node<int>>(n3, new Node<Node<int>>(n4))));
             

             Console.WriteLine(q_7_2(lst));
 

        }

        
    }
}
