//https://www.hackerrank.com/work/library/hackerrank?copyscrape=true&difficulties=Medium&page=2&question=852900&recommended_time=26%2C45&type=backend%2Ccoding&view=question

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;


class BinaryTree{
    
    public virtual bool IsBst(List<int> preorder){
        Stack<int> myStack = new Stack<int>();
        int root = int.MinValue;
        
        foreach(int element in preorder){
            if(element < root){
                return false;
            }
            
            while(myStack.Count > 0 && myStack.Peek() < element){
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

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            int aCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            string result = Result.isValid(a);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
