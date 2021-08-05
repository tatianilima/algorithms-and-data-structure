using System;
using System.Collections;

namespace Morgan.and.a.String
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue firstStack = new Queue();
            Queue secondStack = new Queue();
            string result = "";

            string firstWord = "2";
            string secondWord = "JACK";

            foreach(var element in firstWord.ToCharArray())
            {
                firstStack.Enqueue(element);
            }

            foreach (var element2 in secondWord.ToCharArray())
            {
                secondStack.Enqueue(element2);
            }

            result = GetStack(firstStack, secondStack, result);
            Console.WriteLine(result);            
            Console.ReadLine();
        }

        static string GetStack(Queue firstSTack, Queue secondStack, string result)
        {
            if (firstSTack.Count == 0 && secondStack.Count > 0)
            {
                var secondStackArray = secondStack.ToArray();
                result += string.Join("", secondStackArray); 
                secondStack.Clear();
            }

            if (secondStack.Count == 0 && firstSTack.Count > 0)
            {
                var firstStackArray = firstSTack.ToArray();
                result += string.Join("", firstStackArray);
                firstSTack.Clear();
            }

            if (firstSTack.Count == 0 && secondStack.Count == 0)
                return result;


            //Get fist letter from queue
            var letterFromFirstStack = firstSTack.Peek().ToString();
            var letterFromSecondStack = secondStack.Peek().ToString();
            
            //Convert letters to char
            char charFistLetter = char.Parse(letterFromFirstStack);
            char charSecondLetter = char.Parse(letterFromSecondStack);

            if (charFistLetter < 128)
            {
                firstSTack.Clear();
                return GetStack(firstSTack, secondStack, result);
            }

            if (charSecondLetter < 128)
            {
                secondStack.Clear();
                return GetStack(firstSTack, secondStack, result);
            }

            //compare both
            if ( charFistLetter <= charSecondLetter)
            {
                result += charFistLetter.ToString();
                firstSTack.Dequeue();
            }
            else
            {
                result += charSecondLetter.ToString();
                secondStack.Dequeue();
            }

            //Check stack again
            result = GetStack(firstSTack, secondStack, result);

            return result;
        }
    }
}
