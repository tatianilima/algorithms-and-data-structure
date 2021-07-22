using System;
using System.Collections;

/*
 * *A Queue is used to represent a first-in, first out(FIFO) collection of objects. 
 * It is used when you need first-in, first-out access of items. 
 * It is the non-generic type of collection which is defined in System.Collections namespace. 
 * It is used to create a dynamic collection which grows, according to the need of your program. 
 * In Queue, you can store elements of the same type and of the different types. 
 * 
 * Generally, a queue is helpful when you access that information in the same way in which they stored in the collection and
 * it is temporary storage to store data.
 */
namespace _6_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue myQueue = new Queue();

            //Add Elements in Queue
            myQueue.Enqueue("Tatiani");
            myQueue.Enqueue(1234);
            myQueue.Enqueue(null);            
            myQueue.Enqueue(true);
            myQueue.Enqueue(2.4);

            foreach(var element in myQueue)
                Console.WriteLine(element);

            Console.WriteLine();

            PrintCountElements(myQueue);

            //Peek: This method returns the object at the beginning of the Queue without removing it.
            Console.WriteLine("Topmost element of my_queue is: {0}", myQueue.Peek());

            //Remove be begininning element of the queue
            myQueue.Dequeue();
            PrintCountElements(myQueue);

            //Remove and Obtain the topmost element of queue
            Console.WriteLine("Topmost element of my_queue"
                     + " is: {0}", myQueue.Dequeue());            

            //Remove all elements from the queue
            myQueue.Clear();
            PrintCountElements(myQueue);

            Console.ReadLine();
        }

        static void PrintCountElements(Queue elements)
        {
            Console.WriteLine("Total elements present in myQueue: {0}",
                                                    elements.Count);
        }
    }
}
