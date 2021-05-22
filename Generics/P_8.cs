/*using System;

using System.Text;

namespace Generic
{
    public class P_8
    {

        public static StackArray<string> kita(StackArray<string> strings)
        {
            string stmin = "kkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk";
            StackArray<string> temp = new StackArray<string>();
            while (!strings.IsEmpty())
            {
                string st = strings.Pop();
                if (st.Length < stmin.Length)
                    stmin = st;
                temp.Push(st);
            }
            while (!temp.IsEmpty())
                strings.Push(temp.Pop());
            return strings;
        }

        public static void ps(int m, int n)
        {
            Queue<int> q = new Queue<int>();
            for (int i = 1; i <= n; i++)
                q.Insert(i);
            Console.WriteLine(q);
            while (!q.IsEmpty())
            {
                for (int i = 1; i <= m - 1; i++)
                    q.Insert(q.Remove());
                Console.WriteLine(q.Remove() + " ");
            }

        }

        public static void ds(Stack<string> st2)
        {
            Stack<string> st3 = new Stack<string>();

            while (!st2.isEmpty())
            {
                string str = st2.pop();
                if (str.Length > 4)
                    st3.push(str);
            }
            while (!st3.isEmpty())
                st2.push(st3.pop());
        }

        public static int p8q9(Queue<int> q)
        {
            Queue<int> temp = new Queue<int>();
            int index = 0;
            while (!q.IsEmpty())
            {
                temp.Insert(q.Remove());
                index++;
            }
            while (!temp.IsEmpty())
            {
                q.Insert(temp.Remove());
            }
            return index;
        }// Number of Queue

        public static int p8q10(Stack<int> q)
        {
            int x;
            x = q.pop();
            if (!q.isEmpty())
                return 1 + p8q10(q);
            q.push(x);
            return 1;

        }

        public static Queue<char> p8q12(Queue<char> q)
        {
            Queue<char> newQ = new Queue<char>();
            Queue<char> temp = new Queue<char>();
            while (!q.IsEmpty())
            {
                char t = q.Remove();
                newQ.Insert(t);
                temp.Insert(t);
            }
            while (!temp.IsEmpty())
                q.Insert(temp.Remove());
            return newQ;
        }// Copy Queue

        public static Stack<int> p8q13(Stack<string> q, Stack<int> newS)
        {
            Stack<int> s1 = new Stack<int>();
            if (!q.isEmpty())
            {
                string s = q.pop();
                newS.push(s.Length);
                p8q13(q, newS);
                q.push(s);
            }
            else
            {
                Console.WriteLine(newS);
                while (!newS.isEmpty())
                {
                    int n = newS.pop();
                    s1.push(n);
                }
                Console.WriteLine(s1);
                return s1;
            }
            return null;
        }// Returns a stack of word lengths in the resulting stack

        public static int p8q13(Stack<int>[] skacks)
        {
            int sum = 0;

            for (int i = 0; i < skacks.Length; i++)
            {
                if (!skacks[i].isEmpty())
                    sum += skacks[i].pop();
            }
            return sum;
        }

        public static bool fanc(Queue<int> q)
        {
            Queue<int> temp = new Queue<int>();
            int index = 0;
            bool flag = true;
            while (!q.IsEmpty())
            {
                temp.Insert(q.Remove());
                index++;
            }
            while (!temp.IsEmpty())
            {
                q.Insert(temp.Remove());
            }
            if (index % 2 != 0)
                return false;
            int counter = 0, h = index / 2;
            while (!q.IsEmpty())
            {
                int x = q.Remove();
                int y = q.Remove();

                if (counter < h)
                    if (x > y)
                        return false;
                if (counter > h)
                    if (y > x)
                        return false;
                counter += 2;
            }
            return flag;
        }
       
        public static Queue<int> fanc2(Queue<int> q)
        {
            Queue<int> temp = new Queue<int>();
            int index = 0;

            while (!q.IsEmpty())
            {
                temp.Insert(q.Remove());
                index++;
            }
            while (!temp.IsEmpty())
            {
                q.Insert(temp.Remove());
            }
            int[] arr = new int[index];

            int count = 0, h = index / 2;

            while (!q.IsEmpty())
            {
                if (count % 2 == 0)
                    arr[count] = q.Remove();
                else temp.Insert(q.Remove());
                count++;
            }
            count = 1;
            while (!temp.IsEmpty())
            {
                arr[count] = temp.Remove();
                count += 2;
            }
            for (int i = 0; i < arr.Length; i++)
                temp.Insert(arr[i]);

            return temp;
        }
      
        public static Queue<int> fanc21(Queue<int> q)
        {
            Queue<int> temp = new Queue<int>();
            int index = 0;

            while (!q.IsEmpty())
            {
                temp.Insert(q.Remove());
                index++;
            }
            while (!temp.IsEmpty())
            {
                q.Insert(temp.Remove());
            }
            int[] arr = new int[index];

            int count = 0, h = index / 2;

            while (!q.IsEmpty())
                arr[count++] = q.Remove();

            int i = 0, j = arr.Length - 1;
            int x = 10;
            while (i < j)
            {
                if (x % 2 == 0)
                {
                    q.Insert(arr[i]);
                }
                else if (x % 2 != 0)
                    q.Insert(arr[j--]);
            }
            return q;
        }

        public static string Game()
        {
            int[] arrygame = new int[12];
            Random rand = new Random();
            int i = 0;
            int resP1 = 0, resP2 = 0, ezer = 10;
            while (i < 10)
            {
                if (ezer % 2 == 0)
                {
                    int x = rand.Next(1, arrygame.Length - 1);
                    if (x < 6)
                        arrygame[x]++;
                    else arrygame[x]--;
                }
                else
                {
                    int x = rand.Next(1, arrygame.Length - 1);
                    if (x > 5)
                        arrygame[x]++;
                    else arrygame[x]--;
                }
                int sum1 = 0, sum2 = 0;
                for (int h = 0; h < arrygame.Length; h++)
                {
                    if (arrygame[h] < 6)
                        sum1 += arrygame[h];
                    if (arrygame[h] > 5)
                        sum2 += arrygame[h];
                }
                if (sum2 == 0)
                {
                    for (int h2 = 0; h2 <= 5; h2++)
                    {
                        resP1 += arrygame[h2];
                        if (arrygame[h2] != 0)
                            resP1++;
                    }
                    return "p1 you win sccur:" + resP1;
                }
                else if (sum1 == 0)
                {
                    for (int h2 = 6; h2 < arrygame.Length; h2++)
                    {
                        resP2 += arrygame[h2];
                        if (arrygame[h2] != 0)
                            resP2++;
                    }
                    return "p2 you win sccur:" + resP2;
                }
            }
            for (int h = 0; h < arrygame.Length; h++)
            {
                if (arrygame[h] < 6)
                {
                    resP1 += arrygame[h];
                    if (arrygame[h] != 0)
                        resP1++;

                }
                if (arrygame[h] > 5)
                {
                    resP2 += arrygame[h];
                    if (arrygame[h] != 0)
                        resP2++;
                }
            }
            if (resP1 > resP2)
                return "p1 you win sccur:" + resP1;
            return "p2 you win sccur:" + resP2;

        }
    }
}
*/