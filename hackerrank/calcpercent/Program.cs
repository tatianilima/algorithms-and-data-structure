using System;

//https://www.hackerrank.com/challenges/30-operators/problem
namespace calcpercent
{
    class Program
    {
        static void Main(string[] args)
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine().Trim());

            int tip_percent = Convert.ToInt32(Console.ReadLine().Trim());

            int tax_percent = Convert.ToInt32(Console.ReadLine().Trim());

            solve(meal_cost, tip_percent, tax_percent);
        }

        public static void solve(double meal_cost, int tip_percent, int tax_percent)
        {
            var tip = (meal_cost / 100) * tip_percent;
            var tax = (meal_cost / 100) * tax_percent;
            var total_cost = meal_cost + tip + tax;
            Console.WriteLine(Math.Round(total_cost));
        }
    }
}
