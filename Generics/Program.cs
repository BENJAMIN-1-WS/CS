using System;

namespace Generic
{
    public class Program
    {
        public static void p7()
        {
            Node<int> b = new Node<int>(40,new Node<int>(50,new Node<int>(60)));
            Node<int> a = new Node<int>(10, new Node<int>(20, new Node<int>(30, b)));
            Console.WriteLine(a.printAllNexts());
            P_7.printChain(a);
        } // main activity by P_7 class
        public static void p8()
        {
            Queue<int> a = new Queue<int>();
            a.Insert(10); a.Insert(11); a.Insert(12); a.Insert(13); a.Insert(14);
            Console.WriteLine(a.ToString());
            Console.WriteLine(a.Remove());
            Console.WriteLine(a.ToString());
        } // main activity by P_8 class
        public static void p9()
        {
            List<int> a = new List<int>();
            Node<int> num = new Node<int>(3);
            a.Insert(null, 3); a.Insert(num, 4);
            Console.WriteLine(a.ToString());
        } // main activity by P_9 class
        public static void p10()
        {
            int[] a = { 2, 4, 8, 8, 9 }; 
            int   k = 11;
            P_10.p5(a, k);
        } // main activity by P_10 class
        public static void flower()
        {
            Flower first = new Rose(19,"RED");
            Flower secnd = new Flower(30);
            //bool b = secnd.validHigth();
            //bool b = secnd.validHigth();
            //bool b = first.validHigth();
            bool b = ((Rose)first).validHigth();
            //bool b = ((Rose)secnd).validHigth();
            Console.WriteLine(b);
        } // main activity by Flower class
        public static void stack_func_class() {

            StackFunc stackFunc = new StackFunc();
            Stack<int> s3 = new Stack<int>();
            s3.push(6);s3.push(5);s3.push(4);
            s3.push(3);s3.push(2);s3.push(1);

            bool res = stackFunc.stack_yehodi(s3);
            Console.WriteLine(res);
        } // main activity by StackFunc class
        public static void print_build_BinNode()
        {
            BinNode_int_Methods.BuildSearchTree();
            //BinNode_int_Methods.PrintInOrder(BinNode_int_Methods.BuildSearchTree());
        } // main activity by BinNode_Methods class
        public static void doubleStack_class()
        {
            DoubleStack a = new DoubleStack(16, 2, 29);
            Console.WriteLine(a);
            DoubleStack.order(a); // must be 1 or 2
            Console.WriteLine(a);

        } // main activity by DoubleStack class
        public static void homeWork_935590_class()
        {
            HomeWork_935590._main();
        } // main activity by HomeWork_935590 class
        static void Main(string[] args)
        {
            try
            {
                //stack_func_class();
                // p7();
                // p8();
                // p9();
                // p10();
                // print_build_BinNode();
                // flower();
                //homeWork_935590_class();
                //doubleStack_class();
            }
            catch (Exception err)
            {
                throw err;
            }
                
            
        }
    }
}
