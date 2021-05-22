using System;
using System.Text;

namespace Generic
{
    public class P_7
    {
        public static void printChain(Node<int> x)// Int type printing
        {
            while (x != null)
            {
                Console.WriteLine("-->" + x.GetInfo());
                x = x.GetNext();
            }
        }
        // Deletion of the next link after the link gets a function
        public static void DelNext(Node<int> x)
        {
            if (x.GetNext() != null)
                x.SetNext(x.GetNext().GetNext());
        }
        // Add a link to the place after the patient you receive
        public static void addNode(Node<int> n, int x)
        {
            Node<int> temp = new Node<int>(x, n.GetNext());
            n.SetNext(temp);
            //n.setnext(new Node<int>(x, n.getnext()));
        }
        // Questions Chapter 7 at the end
        // Creates from a sentence a chain that each link is a word
        public static Node<string> nodesQ1_3(string s)
        {
            string[] arrywors = s.Split(' ');
            Node<string> head = new Node<string>(arrywors[0]);
            Node<string> pos = head;
            for (int i = 1; i < arrywors.Length; i++)
            {
                Node<string> temp = new Node<string>(arrywors[i]);
                pos.SetNext(temp);
                pos = pos.GetNext();
            }
            return head;
        }
        // Create a chain of random numbers
        public static Node<int> nodesQ4(int num)
        {
            Random ran = new Random();
            int n = ran.Next(0, 100);
            Node<int> haed = new Node<int>(n);
            Node<int> pos = haed;
            for (int i = 0; i < n - 1; i++)
            {
                n = ran.Next(0, 100);
                Node<int> temp = new Node<int>(n);
                pos.SetNext(temp);
                pos = pos.GetNext();
            }
            return haed;
        }
        // Connecting two chains to each other
        public static void nodesQ5(Node<int> chain1, Node<int> chain2)
        {
            Node<int> pos = chain1;
            while (pos.GetNext() != null)
                pos = pos.GetNext();
            pos.SetNext(chain2);
        }
        // Turning a Chain ****
        public static void nodesQ7(Node<int> chain1)
        {
            Node<int> pos1 = chain1;
            Node<int> pos2 = null;
            Node<int> pos3 = null;
            while (pos1 != null)
            {
                pos2 = pos1.GetNext();
                pos1.SetNext(pos3);
                pos3 = pos1;
                pos1 = pos2;
            }
            chain1 = pos3;
        }
// Extraction of duplicate values in the chain
        public static void nodesQ8(Node<char> chain)
        {
            Node<char> temp = chain;
            Node<char> b_temp = chain;
            while (chain != null && chain.GetNext() != null)
            {
                temp = chain.GetNext();
                b_temp = chain;
                while (temp != null)
                {
                    if (chain.GetInfo() == temp.GetInfo())
                    {
                        b_temp.SetNext(temp.GetNext());
                        Node<char> t = temp.GetNext();
                        temp.SetNext(null);
                        temp = t;
                    }
                    else
                    {
                        b_temp = b_temp.GetNext();
                        temp = temp.GetNext();
                    }
                }
                chain = chain.GetNext();
            }
        }
        // Reverse Print Recursion
        public static string nodesQ9_1(Node<char> chain)
        {
            if (chain.GetNext() == null)
                return chain.GetInfo().ToString();
            return nodesQ9_1(chain.GetNext()) + "," + chain.GetInfo();
        }
        // Reverse printing (not recursion) It is better to look for a shorter method
        public static string nodesQ9_2(Node<char> chain)
        {
            string str = "";
            int counter = 0;
            Node<char> pos = chain;
            while (pos != null)
            {
                counter++;
                pos = pos.GetNext();
            }
            char[] info = new char[counter];
            pos = chain;
            int ind = counter - 1;
            while (pos != null)
            {
                info[ind--] = pos.GetInfo();
                pos = pos.GetNext();
            }
            for (int i = 0; i < info.Length - 1; i++)
                str += info[i] + " , ";
            return str + info[info.Length - 1];
        }
        // Chain sorting
        public static void nodesQ10(Node<int> chain)
        {
            int temp;
            Node<int> pos1 = chain;
            Node<int> pos2;

            while (pos1.GetNext() != null)
            {
                pos2 = pos1.GetNext();
                while (pos2 != null)
                {
                    if (pos1.GetInfo() > pos2.GetInfo())
                    {
                        temp = pos1.GetInfo();
                        pos1.Setinfo(pos2.GetInfo());
                        pos2.Setinfo(temp);
                    }
                    pos2 = pos2.GetNext();
                }
                pos1 = pos1.GetNext();
            }
        }
        // Merge two chains with new links
        public static Node<int> nodesQ11_1(Node<int> chain1, Node<int> chain2)
        {
            Node<int> s = chain1.GetInfo() < chain2.GetInfo() ? chain1 : chain2; // Finds a necklace with the smallest first link
            Node<int> mergeC = new Node<int>(s.GetInfo()); // puts in the new merge chain the smallest value we found above
            if (s == chain1)// Move the appropriate chain one forward
                chain1 = chain1.GetNext();
            else
                chain2 = chain2.GetNext();

            Node<int> pos = mergeC;// Auxiliary pointer to run on the new chain
            while (chain1 != null && chain2 != null)// As long as the chain is not finished (!=null)
            {
                if (chain1.GetInfo() < chain2.GetInfo())
                {
                    pos.SetNext(new Node<int>(chain1.GetInfo(), null));
                    chain1 = chain1.GetNext();
                }
                else
                {
                    pos.SetNext(new Node<int>(chain2.GetInfo(), null));
                    chain2 = chain2.GetNext();
                }
                pos = pos.GetNext();
            }
            Node<int> next = chain1 != null ? chain1 : chain2;
            while (next != null)
            {
                pos.SetNext(new Node<int>(next.GetInfo()));
                next = next.GetNext();
                pos = pos.GetNext();
            }
            Console.WriteLine(mergeC.printAllNexts());
            return mergeC;
        }
        // Merge two chains with the same links
        public static Node<int> nodesQ11_2(Node<int> chain1, Node<int> chain2)
        {
            Node<int> s = chain1.GetInfo() < chain2.GetInfo() ? chain1 : chain2;
            Node<int> mergeC = s;
            if (s == chain1)
                chain1 = chain1.GetNext();
            else
                chain2 = chain2.GetNext();
            Node<int> pos = mergeC;
            while (chain1 != null && chain2 != null)
            {
                if (chain1.GetInfo() < chain2.GetInfo())
                {
                    pos.SetNext(chain1);
                    chain1 = chain1.GetNext();
                }
                else
                {
                    pos.SetNext(chain2);
                    chain2 = chain2.GetNext();
                }
                pos = pos.GetNext();
            }
            s = chain1 == null ? chain2 : chain1;
            while (s != null)
            {
                pos.SetNext(s);
                pos = pos.GetNext();
                s = s.GetNext();
            }
            Console.WriteLine(mergeC.printAllNexts());
            return mergeC;
        }
        // Two different chains until they both point to the same link and become the same chain
        public static void nodeQ12___(Node<int> chain1, Node<int> chain2)
        {
            Node<int> Common_variable = new Node<int>(0); // Pointer the common link
            Node<int> pos1 = chain1;// Pointer to the top of the chain1
            Node<int> pos2 = chain2;// Pointer to the top of the chain2
            bool flag_exit = true;// will stop the loops by chance and we found the joint
            while (pos1 != null && flag_exit)
            {
                while (pos2 != null && flag_exit)
                {
                    if (pos1 == pos2)
                    {
                        Common_variable = pos2; // Pointer the same obj
                        flag_exit = false;
                    }
                    pos2 = pos2.GetNext();
                }
                pos2 = chain2; // Pointer again the beginning of the chain
                pos1 = pos1.GetNext();
            }
            pos2 = chain2;
            Node<int> befor_Common_variable = new Node<int>(0);// will get the link before the common link
            while (pos2 != Common_variable)
            {
                befor_Common_variable = pos2;
                pos2 = pos2.GetNext();
            }
            // Separation of the second chain The common link
            // What leaves the first chain isolated Now we will take care of the second chain
            befor_Common_variable.SetNext(new Node<int>(Common_variable.GetInfo()));
            // We placed the value of the common link in a new link and connected it to the second chain
            // All that remains is to add the sequel to the second chain

            befor_Common_variable = befor_Common_variable.GetNext(); // Now points to the last limb in the second chain
            pos1 = chain1;// Points back to the top of the list
            flag_exit = true;// Auxiliary variable
            while (pos1 != null && flag_exit)
            {
                if (pos1 == Common_variable && flag_exit)
                {
                    while (pos1 != null)
                    {
                        befor_Common_variable.SetNext(new Node<int>(pos1.GetInfo()));
                        pos1 = pos1.GetNext();
                        flag_exit = false;
                    }
                }
                pos1 = flag_exit ? pos1.GetNext() : pos1;
            }
            // Proof check
            Console.WriteLine(chain1.GetNext().GetNext().Equals(chain2.GetNext().GetNext()));
            Console.WriteLine(chain1.printAllNexts());
            Console.WriteLine(chain2.printAllNexts());

        }
       
        public static void P7Q12(Node<int> chain1, Node<int> chain2)
        {
            Node<int> Common_variable = new Node<int>(0); // Pointer the common link
            Node<int> pos1 = chain1;// Pointer to the top of the chain1
            Node<int> pos2 = chain2;// Pointer to the top of the chain2
            bool flag_exit = true;// will stop the loops by chance and we found the joint
            while (pos1 != null && flag_exit)
            {
                while (pos2 != null && flag_exit)
                {
                    if (pos1 == pos2)
                    {
                        Common_variable = pos2; // Pointer the joint organ
                        flag_exit = false;
                    }
                    pos2 = pos2.GetNext();
                }
                pos2 = chain2;// Pointer again the beginning of the chain
                pos1 = pos1.GetNext();
            }
            pos1 = chain1;
            pos2 = chain2;
            while (pos1.GetNext() != Common_variable)
                pos1 = pos1.GetNext();
            while (pos2.GetNext() != Common_variable)
                pos2 = pos2.GetNext();
            while (Common_variable != null)
            {
                Node<int> x = new Node<int>(Common_variable.GetInfo());
                Node<int> x2 = new Node<int>(Common_variable.GetInfo());
                pos1.SetNext(new Node<int>(Common_variable.GetInfo()));
                pos2.SetNext(new Node<int>(Common_variable.GetInfo()));
                pos1 = pos1.GetNext();
                pos2 = pos2.GetNext();
                Common_variable = Common_variable.GetNext();
            }
        }

        public static void What_i_ame_doing(Node<int> p, int n)
        {
            Node<int> pos;
            while (n != 0 && p.GetNext().GetNext() != null)
            {
                /*1*/
                pos = p.GetNext();
                /*2*/
                p.SetNext(pos.GetNext());
                /*3*/
                pos.SetNext(p.GetNext().GetNext());
                /*4*/
                p.GetNext().SetNext(pos);
                /*5*/
                n--;
                /*6*/
                p = p.GetNext();
            }
        }

        public static void SortChainOfNodes(Node<int> chain)// Sort list
        {
            Node<int> PrevePos = chain;
            Node<int> posNode = chain.GetNext();
            bool flag = true;
            while (flag)
            {
                flag = false;
                while (posNode != null)
                {

                    if (PrevePos.GetInfo() > posNode.GetInfo())
                    {
                        int temp = PrevePos.GetInfo();
                        PrevePos.Setinfo(posNode.GetInfo());
                        posNode.Setinfo(temp);
                        flag = true;
                    }
                    PrevePos = PrevePos.GetNext();
                    posNode = posNode.GetNext();
                }
                PrevePos = chain;
                posNode = chain.GetNext();
            }
        }

    }
}
