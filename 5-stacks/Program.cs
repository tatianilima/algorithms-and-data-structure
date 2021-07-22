using System;
using System.Collections;

/*
 * A Stack represents a last-in, first-out collection of objects. 
 * It is used when you need last-in, first-out access to items. 
 * It is both a generic and non-generic type of collection. 
 * The generic stack is defined in System.Collections.Generic namespace whereas non-generic stack is defined 
 * under System.Collections namespace, here we will discuss non-generic type stack. A stack is used to create a 
 * dynamic collection that grows, according to the need of your program. 
 * 
 * In a stack, you can store elements of the same type or different types.
 * */
namespace _5_stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack mystack = new Stack();

            //Add Elements
            mystack.Push("Tatiani");
            mystack.Push(" - ");
            mystack.Push("Leandro");
            mystack.Push(37);
            mystack.Push(null);
            mystack.Push(true);
            mystack.Push(12.34);

            //Acessing elements
            foreach (var element in mystack)
                Console.WriteLine(element);

            Console.WriteLine();

            PrintCountElements(mystack);
            
            //Remove the begininning element of the stack
            mystack.Pop();

            PrintCountElements(mystack);

            //Remove all elements from stack
            mystack.Clear();

            PrintCountElements(mystack);

            Console.ReadLine();
        }

        static void PrintCountElements(Stack mystack)
        {
            Console.WriteLine("Total elements present in" +
                    " mystack: {0}", mystack.Count);
        }
    }
}
