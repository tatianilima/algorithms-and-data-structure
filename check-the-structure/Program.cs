using System;
using System.Collections.Generic;
using System.Linq;

namespace check_the_structure
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine().Trim());

            for (int qItr = 0; qItr < q; qItr++)
            {
                int aCount = Convert.ToInt32(Console.ReadLine().Trim());

                List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

                string result = Result.isValid(a);

                Console.WriteLine(result);
            }
        }
    }
    class BinaryTree
    {
        public virtual bool IsBst(List<int> preorder)
        {
            Stack<int> myStack = new Stack<int>();
            int root = 0;

            foreach (int element in preorder)
            {
                if (element < root)
                {
                    return false;
                }

                while (myStack.Count > 0 && myStack.Peek() < element)
                {
                    root = myStack.Peek();
                    myStack.Pop();
                }

                myStack.Push(element);
            }

            return true;
        }
    }
    class Result
    {

        /*
         * Complete the 'isValid' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts INTEGER_ARRAY a as parameter.
         */

        public static string isValid(List<int> a)
        {
            BinaryTree myTree = new BinaryTree();
            return (myTree.IsBst(a)) ? "YES" : "NO";
        }

    }
}
