using System;
using System.Text;

namespace Generic
{

    class BinNode_int_Methods
    {
        public static BinNode<int> BuildSearchTree()
        // --- Building a binary search tree ---
        {
            // --- Construction of a first junction in the tree ---
            Console.Write ("first number (-1 to finish) --> ");
            int num = int.Parse(Console.ReadLine());
            BinNode<int> bt = new BinNode<int>(num);
            // --- Input and adding the following nodes ---
            Console.Write ("next number (-1 to finish) --> ");
            num = int.Parse(Console.ReadLine());
            while (num != -1)
            {
                Add_Recursive(bt, num);  // OR->  Add_Iterative(bt, num); 
                Console.Write("next number (-1 to finish) --> ");
                num = int.Parse(Console.ReadLine());
            }
            return bt;
        }

        public static void PrintInOrder(BinNode<int> bt)
        // --- Display tree nodes in parrot order ---
        {
            if (bt != null)
            {
                PrintInOrder(bt.GetLeft());
                Console.Write(bt.GetValue() + ", ");
                PrintInOrder(bt.GetRight());
            }
        }

        public static void Add_Iterative(BinNode<int> bt, int x)
        // --- Display tree nodes in parrot order ---
        {
            BinNode<int> t = new BinNode<int>(x);
            while (x < bt.GetValue() && bt.HasLeft() ||
            x >= bt.GetValue() && bt.HasRight())
            {
                if (x < bt.GetValue())
                    bt = bt.GetLeft();
                else
                    bt = bt.GetRight();
            }
            if (x < bt.GetValue())
                bt.SetLeft(t);
            else
                bt.SetRight(t);
        }
        public static void Add_Recursive(BinNode<int> bt, int x)
        // --- An action that adds a node to a binary search tree recursively ---
        {
            if (x < bt.GetValue())
            {
                if (!bt.HasLeft()) // If there is no left son
                    bt.SetLeft(new BinNode<int>(x)); // Setting the node as a left son
                else
                    Add_Recursive(bt.GetLeft(), x); // Continue searching for the appropriate place on the left
            }
            else // x >= bt.GetValue()
            {
                if (!bt.HasRight()) // If there is no right-wing son
                    bt.SetRight(new BinNode<int>(x)); // Setting the node as a right-hander
                else
                    Add_Recursive(bt.GetRight(), x); // Continue searching for the appropriate place on the right
            }
        }

        public static bool Exist_Recursive(BinNode<int> bt, int x)
        // --- bt is found in a binary search tree x an action that returns "true" if ---
        // --- and another "lie" - ---
        {
            if (bt == null)
                return false;
            if (bt.GetValue() == x)
                return true;
            if (x < bt.GetValue())
                return Exist_Recursive(bt.GetLeft(), x);
            return Exist_Recursive(bt.GetRight(), x);
        }

        public static bool Exist_Iterative(BinNode<int> bt, int x)
        // --- bt is found in a binary search tree x an action that returns "true" if ---
        // --- and another "lie" - ---
        {
            while (bt != null)
            {
                if (bt.GetValue() == x)
                    return true;
                if (x < bt.GetValue())
                    bt = bt.GetLeft();
                else
                    bt = bt.GetRight();
            }
            return false;
        }

        public static BinNode<int> GetNode(BinNode<int> bt, int x)
        // --- An action that receives a search and number tree, and returns a reference to the node. ---
        // --- null If the value is not in the tree will be returned ---
        {
            if (bt == null || bt.GetValue() == x)
                return bt;
            if (x < bt.GetValue())
                return GetNode(bt.GetLeft(), x);
            return GetNode(bt.GetRight(), x);
        }

        public static int Biggest(BinNode<int> bt)
        // --- Search in the largest tree and organ finding ---
        // --- Recursion null is not the discount tree: --- ---
        {
            if (bt.HasRight())
                return bt.GetValue();
            return Biggest(bt.GetRight());
        }

        public static int Smallest(BinNode<int> bt)
        // --- Search in the smallest tree and organ finding ---
        // --- null is not the discount tree: ---
        {
            while (bt.HasLeft())
                bt = bt.GetLeft();
            return bt.GetValue();
        }
    }
            /*/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\//\/\|
            |//////////////////////////////////////////////////////|
            |//////////////////////////////////////////////////////|
            |/////       \///////         \////     \////    //////|
            |////         \//////         /////      \///    //////|
            |////   ///\   \/////     /////////       \//    //////|
            |////   ///    //////         /////        \/    //////|
            |////        ////////         /////    /\        //////|
            |////   ///    \/////     /////////    //\       //////|
            |////   ///      \///         /////    ///\      //////|
            |////           /////         /////    ////\     //////|
            |//////////////////////////////////////////////////////|
            |///////////////////////////////////////////NOIOFF/////|
            |/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\//\/\|*/
}