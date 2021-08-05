using System;
using System.Collections;
using System.Globalization;

namespace A_datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";


            // Declare second integer, double, and String variables.
            int a;
            double b;
            string c;

            // Read and save an integer, double, and String to your variables.
            a = Int32.Parse(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Console.ReadLine();

            // Print the sum of both integer variables on a new line.
            Console.WriteLine(a + i);

            // Print the sum of the double variables on a new line.
            Console.WriteLine(string.Format("{0:N1}", b + d));

            // Concatenate and print the String variables on a new line
            Console.WriteLine(s + c);

            // The 's' variable above should be printed first.
        }
    }
}
