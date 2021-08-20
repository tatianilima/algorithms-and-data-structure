using System;

namespace isprimer
{
    class Program
    {
        static void Main(string[] args)
        {
            string result;
            int amountTests = Convert.ToInt32(Console.ReadLine());

            while (amountTests-- > 0)
            {
                int element = Convert.ToInt32(Console.ReadLine());
                result = (IsPrime(element)) ? "Prime" : "Not Prime";
                Console.WriteLine(result);
            }
        }

        public static bool IsPrime(int element)
        {
            int count = 0;
            if (element == 1) //not prime
            {
                return false;
            }
            else if (element == 2) //prime
            {
                return true;
            }

            int i = 1;
            var amountElements = Math.Sqrt(element); //Isso tira uma operação do loop, economizando muitos ciclos de CPU ao lidar com números maiores.

            while (i++ < amountElements)
            {
                count++;
                int calc = element % i;
                if (calc == 0)
                {
                    return false;
                }
            }
            return (count > 0);
        }
    }
}
