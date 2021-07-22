using System;
using System.Text;

/*
 * C# introduced the StringBuilder in the System.Text namespace. 
 * The StringBuilder doesn't create a new object in the memory but dynamically expands memory to accommodate the modified string.
 * */
namespace stringbuilder.exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "white", " - ", "black", " - ", "blue", " - ", "gray" };
            string firstWay = FirstWay(words);
            Console.WriteLine(firstWay);
            Console.WriteLine();

            string secondWay = SecondWay(words);
            Console.WriteLine(secondWay);

            Console.ReadLine();
        }

        static string FirstWay(string[] words)
        {
            string sentence = "";
            foreach (string w in words)
                sentence = sentence + w;

            return sentence;
        }

        static string SecondWay(string [] words)
        {
            StringBuilder sentence = new StringBuilder();
            foreach (string w in words)
                sentence.Append(w);

            return sentence.ToString();
        }
    }
}
