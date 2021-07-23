using System;
/*
 * A tree whose elements have at most 2 children is called a binary tree. 
 * Since each element in a binary tree can have only 2 children, we typically name them the left and right child.
 */


namespace _7_Binary.Tree
{
    public class Node
    {
        public int leaf;
        public Node left;
        public Node right;

        public Node(int item)
        {
            leaf = item;
            left = null;
            right = null;
        }
    }

    public class BinaryTree
    {
        //Root of binary tree
        Node root;

        BinaryTree(int leaf)
        {
            root = new Node(leaf);
        }

        BinaryTree()
        {
            root = null;
        }

        public static void Main()
        {
            //create a new binary tree
            BinaryTree tree = new BinaryTree();

            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);

            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);
        }
    }

    
}
