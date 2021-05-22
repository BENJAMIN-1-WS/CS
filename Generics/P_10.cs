using System;
using System.Text;

namespace Generic
{
    public class P_10    //    http://blog.csit.org.il/UpLoad/FilesUpload/T381_16B.pdf
    { 
        public static bool p4(List<int> L1)
        { // Receives an integer type list and checks if the list is a triple list
            int count = 0;
            Node<int> pos = L1.GetFirst();
            while (pos != null) 
            {
                count++;
                pos = pos.GetNext();
            }

            if(count ==0 || count%3 != 0) { return false; }

            // ________________  count = len(L1)  ________________ //
           int len = count / 3;

            Node<int> p1 = L1.GetFirst();
            Node<int> p2 = p1;
            Node<int> p3 = null;
            for (int i = 0; i < len; i++) 
            {
                p2 = p2.GetNext();
            }
            p3 = p2;

            for (int j = 0; j < len; j++)
            {
                while (p3 != null) 
                {
                    if (p1.GetInfo() != p2.GetInfo() || p2.GetInfo() != p3.GetInfo()){
                        return false;
                    }
                    p1 = p1.GetNext();
                    p2 = p2.GetNext();
                    p3 = p3.GetNext();
                }
            }
                return true;

        }
        public static void p5(int[] a, int k)
        {
            Console.WriteLine(what_p5(a,k));
            Console.WriteLine(sod_p5(a,k));
        }
        // The function checks if there are two numbers in the array that are equal to the value of k
        public static bool what_p5(int[]a,int k) 
        { 
            for (int i = 0; i < a.Length-1; i++)
            {
                int j = 1 + i;
                while (j<a.Length)
                {
                    if (a[i]+a[j]==k)
                        return true;
                    j++;
                }
            }
            return false;
        }
        public static bool sod_p5(int[] a, int k)// The function checks on both sides of the array >[,,]<
        {
            int left = 0; int right = a.Length - 1;
            while (left < right)
            {
                if (a[left] + a[right] == k)
                    return true;
                if (a[left] + a[right] < k)
                    left++;
                else
                    right--;
            }
            return false;
        }
    }
}
