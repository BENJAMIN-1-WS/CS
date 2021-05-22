using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    class DoubleStack
    {
        private Stack<int> stack1;
        private Stack<int> stack2;
        public DoubleStack(int n, int x, int y)
        {
            Random rand = new Random();
            stack1 = new Stack<int>();
            stack2 = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                if (rand.Next(1, 3) == 1)stack1.push(rand.Next(x, y + 1)); 
                else stack2.push(rand.Next(x, y + 1));
            }
        }
        
        public int NumElements(int num)
        {
            
            if (num > 2 || num < 1) { return -1; }
            int count1 = 0;
            Stack<int> pos1 = new Stack<int>();
            if( num == 1){
            while (!stack1.isEmpty()) { pos1.push(stack1.pop()); count1++; }
            while (!pos1.isEmpty()) stack1.push(pos1.pop());
            }
            else
            {
                while (!stack2.isEmpty()) { pos1.push(stack2.pop()); count1++; }
                while (!pos1.isEmpty()) stack2.push(pos1.pop());
            }
            return count1;
        }
        public void Move(int num)
        {
            if (num > 2 || num < 1) { Console.WriteLine("must b 1 or 2"); return; }
            if (num == 1)stack1.push(stack2.pop());
            else stack2.push(stack1.pop());
        }
        public void MoveMin(int num)
        {
            if (num < 1 || num > 2) { Console.WriteLine("err"); return; }
            Stack<int> temp = new Stack<int>();
            int min = Int32.MaxValue;
            int hasMin = -1;
            if (num == 1)
            {
                while (!stack1.isEmpty())
                {
                    int number = stack1.pop();
                    if (min > number) min = number;
                    temp.push(number);
                }
                bool f = true;
                while (!temp.isEmpty())
                {
                    int number = temp.pop();

                    if (min == number && f)
                    {
                        f = false;
                    }
                    else if (!f || number != min)
                    {
                        stack1.push(number);
                    }
                }
                stack2.push(min);
            }
            else
            {
                while (!stack2.isEmpty())
                {
                    int number = stack2.pop();
                    if (min > number)
                    {
                        hasMin = number.GetHashCode();
                        min = number;
                    }
                    temp.push(number);
                }
                bool f = true;
                while (!temp.isEmpty())
                {
                    int number = temp.pop();
                    if (min == number && f)
                    {
                        f = false;
                    }
                    else if (!f || number != min)
                    {
                        stack2.push(number);
                    }
                }
                stack1.push(min);
            }
        }
        public override string ToString()
        {
            return stack1.ToString()+"\n"+stack2.ToString();
        }
        public static void order(DoubleStack ds)
        {
            int len1 = 0, len2=0;
            while (ds.NumElements(1)> 0)
            {
                ds.MoveMin(1);
                len1++;
            }
            while (len1 >= 0)
            {
                ds.MoveMin(2);
                len1--;
            }

            while (ds.NumElements(2) > 0)
            {
                ds.MoveMin(2);
                len2++;
            }
            while (len2 >= 0)
            {
                ds.MoveMin(1);
                len2--;
            }

        }


    }


}
