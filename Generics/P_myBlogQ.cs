/*using System;

using System.Text;

namespace Generic
{
    public  class P_myBlogQ
    {
        public static bool IsExist(Stack<int> stk, int num)// does not maintain the stack structure
        {
            if (stk.isEmpty())
                return false;
            int n = stk.pop();
            if (n % 10 == num)
                return true;
            return IsExist(stk, num);
        }
        
        public static bool IsExist2(Stack<int> stk, int num)
        {
            bool flag = false;
            Stack<int> newstk = new Stack<int>();
            if (stk.isEmpty())
                return false;

            while (!stk.isEmpty())
            {
                int n = stk.pop();
                newstk.push(n);
                if (n % 10 == num)
                    flag = true;
            }
            while (!newstk.isEmpty())
                stk.push(newstk.pop());
            return flag;
        }
        
        public static bool IsExist3(Stack<int> stk)
        {
            Stack<int> newstk = new Stack<int>();
            int counter = 0;
            if (stk.isEmpty())
                return false;
            while (!stk.isEmpty())
            {
                newstk.push(stk.pop());
                counter++;
            }
            int[] arryF = new int[counter];
            int[] arryA = new int[counter];
            int s = counter;
            counter = 0;
            while (!newstk.isEmpty())
            {
                int n = newstk.pop();
                int x = n;
                arryA[counter] = n % 10;
                while (n > 10)
                    n /= 10;
                arryF[counter++] = n;
                stk.push(x);
            }
            int sumTrue = 0;

            for (int i = 0; i < arryF.Length; i++)
            {
                for (int j = 0; j < arryA.Length; j++)
                {
                    if (arryF[i] == arryA[j])
                        sumTrue++;
                }
            }

            return sumTrue == s;
        }// Do all significant numbers appear in the unity digits

        public static int q19_4(Queue<int> q1)//196    6  9 1 
        {
            int num = 0;
            int x = 1;
            while (!q1.IsEmpty())
            {
                int y = q1.Remove();
                num += y * x;
                x *= 10;
            }
            return num;
        }
       
        public static int q19_42(Queue<int> q1) //691    6  9 1 
        {
            int counter = 0;
            Queue<int> q2 = new Queue<int>();
            while (!q1.IsEmpty())
            {
                q2.Insert(q1.Remove());
                counter++;
            }
            int num = 0;
            int x = 1;
            for (int i = 1; i < counter; i++)
                x *= 10;
            while (!q2.IsEmpty())
            {
                int y = q2.Remove();
                num += y * x;
                x /= 10;
            }
            return num;
        }

        //public static bool q18_4(StackList<int> stk)

        public static void Mdogma4(AllList head)// Sorting a linear list with sub-lists of one-way chains
        {// so that we can print all the sub-lists in a sorted way

            AllList pos = head;
            Node<int> posNode = head.getFirst();
            Node<int> PrevePos = posNode.getNext();
            while (pos != null)
            {
                bool flag = true;
                while (flag)
                {
                    flag = false;
                    while (posNode != null)
                    {
                        if (PrevePos.getInfo() > posNode.getInfo())
                        {
                            int n = PrevePos.getInfo();
                            PrevePos.setInfo(posNode.getInfo());
                            posNode.setInfo(n);
                        }
                        PrevePos = PrevePos.getNext();
                        posNode = posNode.getNext();
                    }
                    posNode = head.getFirst();
                    PrevePos = posNode.getNext();
                }
            }

        }

        // Taking digits that are not in the block (adjacent digits) to a new stack
        public static Stack<int> p20_b_4(Stack<int>numbers)
        {
            Stack<int> res = new Stack<int>();
            if (numbers.isEmpty()) return res;
            int number1 = numbers.pop(),number2,count=1;
            while (!numbers.isEmpty())
            {
                number2 = numbers.pop();
                if (number1 == number2) count++;

                else
                {
                    if (count == 1) res.push(number1);

                    count = 1;
                }
                number1 = number2;
            }

            return res;
        }


    }
}
*/