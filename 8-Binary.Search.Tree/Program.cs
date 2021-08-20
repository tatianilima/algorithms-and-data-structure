using System;
using System.Collections.Generic;
/*
* Binary Search Tree is a binary tree in wich every node fits a especific ordering property: 
* all left descendents <= n < all right descendents. Its must be true for each node n.
* Exercise based in https://betterprogramming.pub/introduction-to-binary-search-trees-dde166368210
*/
namespace _8_Binary.Search.Tree
{
    class Node
    {
        public int node;
        Node left;
        Node right;

        public Node(int data)
        {
            node = data;
            left = null;
            right = null;
        }

        public void AddNode(Node root)
        {
            //root.leaf == leaf -> duplicate values are not allowed
            if (root.node == node || root.node == node) //root.node traz o valor anterior e node traz o valor atual
                return;

            //conditions to add left and right node
            if (node < root.node)
            {
                if (root.left != null)
                {
                    AddNode(root.left);
                }
                else
                {
                    root.left = this;
                }
            }else if (node > root.node)
            {
                if (root.right != null)
                {
                    AddNode(root.right);
                }
                else
                {
                    root.right = this;
                }
            }
        }
    }

    class BinaryTree
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputArray = input.Split(" ");
            Node root = null;
            List<Node> binaryTree = new List<Node>(); 
            foreach (string element in inputArray)
            {
                Node n = new Node(Convert.ToInt32(element));

                if (root == null)
                {
                    root = n;
                }
                else
                {
                    n.AddNode(root);
                }
                binaryTree.Add(n);
            }

            Console.ReadLine();
        }

        static void RandonNumbersTest()
        {
            Node root = null;
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                int x = rnd.Next(0, 100);
                Node n = new Node(x);
                if (root == null)
                {
                    Console.WriteLine("Setting " + n.node + " to the root");
                    root = n;
                }
                else
                {
                    n.AddNode(root);
                }
            }

            Console.ReadLine();
        }
    }
}
