using System;

namespace day3.evenodd
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine().Trim());
            //check if N is even 
            bool isOdd = N % 2 > 0; //impar odd
            bool isEven = N % 2 == 0; //par even

            if (isOdd)
            {
                Console.WriteLine("Weird");
            }
            else if (isEven && N >= 2 && N <= 5)
            {
                Console.WriteLine("Not Weird");
            }
            else if (isEven && N >= 6 && N <= 20)
            {
                Console.WriteLine("Weird");
            }
            else if (isEven && N > 20)
            {
                Console.WriteLine("Not Weird");
            }
        }
    }
}
