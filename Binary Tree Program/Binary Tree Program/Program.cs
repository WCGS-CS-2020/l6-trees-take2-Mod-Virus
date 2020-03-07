using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Ivans_Library;

namespace Binary_Tree_Program
{

    /*
     * Tasks:
     * 1) Complete the implementation of the Node methods
     * 2) Print out the tree using the different tree traversal metods
     * 3) Test findNote() and deleteNode()
     *
     *
     */
    class Node
    {
        // Attributes
        private Node left;
        private Node right;
        private int item;

        //Methods
        public Node(int item)
        {
            this.item = item;
        }

        public void addNode(int item)
        {
            if (item < this.item)
            {
                if (left == null)
                {
                    left = new Node(item);
                }
                else
                {
                    left.addNode(item);
                }
            }
            else if (item > this.item)
            {
                if (right == null)
                {
                    right = new Node(item);
                }
                else
                {
                    right.addNode(item);
                }
            }
        }

        public Boolean findNode(int item)
        {
            bool holder;
            if (item == this.item)
            {
                return (true);
            }
            else if (item < this.item)
            {
                holder = left.findNode(item);
                return (holder);
            }
            else if (item > this.item)
            {
                holder = right.findNode(item);
                return (holder);
            }
            else
            {
                return false;
            }
        }

        public Boolean deleteNote(int item)
        {
            return true;
        }

        protected void postTraverse()
        { 
            if (left != null)
            {
                left.postTraverse();
            }
            if (right != null)
            {
                right.postTraverse();
            }
            Console.Write(item + " ");
        }

        public void printTree()
        {
            Console.WriteLine("How would you like to print the tree?");
            string[] options = { "Pre Order Traversal", "In Order Traversal", "Post Order Traversal"};
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine(String.Format("{0}. {1}", (i + 1), options[i]));
            }
            int selection = Function.Int_Check();
            selection = Function.Range_Check(selection, 1, 3);
            Console.WriteLine();
            switch (selection)
            {
                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    postTraverse();
                    break;
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Node root = null;

            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            int[] numArray = { 22, 45, 12, 67, 84, 56, 444, 5456, 6, 43, 36, 47 };

            // process all the nodes on the array
            //
            foreach (var num in numArray)
            {
                if (root == null)
                    root = new Node(num);
                else
                    root.addNode(num);
            }

            // print out the tree using different traversal methods
            // Test the findNote() and deleteNode()
            string[] options = { "Print Node", "Find Node", "Delete Node", "Exit" };
            int item;
            bool end = false;

            while (end == false)
            { 
                Function.Underline("Binary Tree Program");
                Console.WriteLine("Choose an option:");

                for (int i = 0; i < options.Length;i++)
                {
                  Console.WriteLine(String.Format("{0}. {1}",(i+1),options[i]));  
                }

                int selection = Function.Int_Check();
                selection = Function.Range_Check(selection, 1, 4);

                Console.Clear();
                Function.Underline("Binary Tree Program");

                switch (selection)
                {
                    case 1:
                        root.printTree();
                        Thread.Sleep(5000);
                        Console.Clear();
                        break;

                    case 2:
                        Console.WriteLine("Please enter the node you would like to find:");
                        item = int.Parse(Console.ReadLine());
                        root.findNode(item);
                        Console.Clear();
                        break;

                    case 3:
                        Console.WriteLine("Please enter the node you would like to delete:");
                        item = int.Parse(Console.ReadLine());
                        root.deleteNote(item);
                        Console.Clear();
                        break;

                    case 4:
                        end = true;
                        break;
                }
            }

            
            
        }
    }
}
