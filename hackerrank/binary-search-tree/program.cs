using System;
class Node{
    public Node left,right;
    public int data;
    public Node(int data){
        this.data=data;
        left=right=null;
    }
}
class Solution{

	static int getHeight(Node root){
      //Write your code here
      if(root == null){
          return -1;
      }
      int left = getHeight(root.left);
      int right = getHeight(root.right);
      int biggestNumber = Math.Max(left, right);
      return biggestNumber + 1;
    }

	static Node insert(Node root, int data){
        if(root==null){
            return new Node(data);
        }
        else{
            Node cur;
            if(data<=root.data){
                root.left=insert(root.left,data);
            }
            else{
                root.right=insert(root.right,data);
            }
            return root;
        }
    }
    static void Main(String[] args){
        Node root=null;
        int T=Int32.Parse(Console.ReadLine());
        while(T-->0){
            int data=Int32.Parse(Console.ReadLine());
            root=insert(root,data);            
        }
        int height=getHeight(root);
        Console.WriteLine(height);
        
    }
}