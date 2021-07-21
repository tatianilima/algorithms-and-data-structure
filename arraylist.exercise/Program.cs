using System;
using System.Collections;

namespace arraylist.exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var arlist = new ArrayList()
                {
                    2, "Steve", " ", true, 4.5, null
                };
            var firstElement = arlist[0];
            var secondElement = arlist[1];
            Console.WriteLine(firstElement);
            Console.WriteLine(secondElement);

            Console.WriteLine("=================================");
            arlist.Insert(1, "Second Item");

            foreach (var val in arlist)
                Console.WriteLine(val);
            Console.WriteLine("=================================");

            Console.ReadLine();
        }
    }
}
