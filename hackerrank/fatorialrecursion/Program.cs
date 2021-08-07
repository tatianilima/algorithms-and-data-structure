using System;
/*
 * Conhecemos como fatorial de um número natural a multiplicação desse número 
 * por seus antecessores com exceção do zero.
 */
namespace fatorialrecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;

            int result = factorial(n);

            Console.WriteLine(result);
        }

        public static int factorial(int n)
        {
            if (n == 1 || n == 0)
                return 1;
            else
                return n * factorial(n - 1);

        }
    }
}
