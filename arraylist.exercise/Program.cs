using System;
using System.Collections;

/*
 * In C#, the ArrayList is a non-generic collection of objects whose size increases dynamically. 
 * It is the same as Array except that its size increases dynamically.
 */

namespace arraylist.exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstExercise();
            Console.WriteLine();
            SecondExercise();

            Console.ReadLine();
        }

        static void FirstExercise()
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

        }

        static ArrayList Merge(String[] words, String[] more)
        {
            ArrayList sentences = new ArrayList();
            foreach (var w in words)
            {
                sentences.Add(w);
            }

            foreach (var m in more)
            {
                sentences.Add(m);
            }

            return sentences;
        }

        static void SecondExercise()
        {
            string[] words = { "water", "chicken", "fish" };
            string[] more = { "onion", "lettuce", "rice" };
            ArrayList mergeSentences = Merge(words, more);
            foreach (var val in mergeSentences)
                Console.WriteLine(val);            
        }
    }
}
