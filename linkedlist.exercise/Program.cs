using System;
using System.Collections.Generic;

/*
 * Like arrays, Linked List is a linear data structure. 
 * Unlike arrays, linked list elements are not stored at a contiguous location; the elements are linked using pointers.
 * Concept: https://www.geeksforgeeks.org/linked-list-set-1-introduction/
 * */
namespace linkedlist.exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> elements =  FirstWay();
            PrintElements(elements);

            RemoveElements(elements, "March");
            PrintElements(elements);
            
            Console.ReadLine();
        }

        static LinkedList<string> FirstWay()
        {
            LinkedList<string> months = new LinkedList<string>();
            months.AddLast("December");
            months.AddFirst("January");

            var january = months.Find("January");
            var december = months.Find("December");

            months.AddAfter(january, "February");
            months.AddBefore(december, "November");

            var node = new LinkedListNode<string>("March");
            months.AddLast(node);
            return months;
        }

        static LinkedList<string> RemoveElements(LinkedList<string> elements, string element)
        {
            elements.Remove(element);
            return elements;
        }

        static void PrintElements(LinkedList<string> elements)
        {
            foreach (var element in elements)
                Console.WriteLine(element);
            Console.WriteLine();
        }
    }
}
