﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

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
        private string item;

        //Methods
        public Node(string item) 
        {
            this.item = item;
        }
        
        public void addNode(string item) 
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
            else
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
        
        public Boolean findNode(string item) 
        { 
            return true; 
        }
        
        public Boolean deleteNote(string item) 
        { 
            return true; 
        }
        
        void printTree() 
        { 
            
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
            foreach (var mon in months)
            {
                if (root == null)
                    root = new Node(mon);
                else
                    root.addNode(mon);
            }

            // print out the tree using different traversal methods
            //

            // Test the findNote() and deleteNode()
        }
    }
}

