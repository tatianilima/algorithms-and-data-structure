using System;
/*
 * Binary Search Tree is a binary tree in wich every node fits a especific ordering property: 
 * all left descendents <= n < all right descendents. Its must be true for each node n.
 * Exercise based in https://betterprogramming.pub/introduction-to-binary-search-trees-dde166368210
 */
namespace _8_Binary.Search.Tree
{
    class Node
    {
        public int leaf;
        Node left;
        Node right;

        public Node(int data)
        {
            leaf = data;
            left = null;
            right = null;
        }

        public void AddNode(Node root)
        {
            //root.leaf == leaf -> duplicate values are not allowed
            if (root == null || root.leaf == leaf)
                return;
            //TODO: Add here conditions to add left and right node
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Node root = null;
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                int x = rnd.Next(0, 100);
                Node n = new Node(x);
                if (root == null)
                {
                    Console.WriteLine("Setting " + n.leaf + " to the root");
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
