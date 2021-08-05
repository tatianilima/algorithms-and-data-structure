using System;

//https://www.hackerrank.com/challenges/camelcase/problem 

namespace _2_CamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "saveChangesInTheEditor";
            int countWords = 0;
            char[] letters = word.ToCharArray();
            
            if (letters[0].ToString() != letters[0].ToString().ToUpper())
            {
                countWords++;
            }

            foreach (var l in letters)
            {
                if (l.ToString() == l.ToString().ToUpper())
                {
                    countWords++;
                }
            }
            Console.WriteLine(countWords);
            Console.ReadLine();
        }
    }
}
