using System;

using System.Text;

namespace Generic
{
    public class StackFunc
    {

        public bool stack_yehodi(Stack<int> stk)
        {
            if (stk.isEmpty())
                return false;
            while (!stk.isEmpty())
            {
                int n = stk.pop();
                bool check = IsExist(stk, n);
                if (check) { return false; }

            }
            return true;
        }
        public static bool IsExist(Stack<int> stk, int num)
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
        } // Checks if any number is on the list

        // public bool func1() { }

        // public bool func2() { }

    }
}
