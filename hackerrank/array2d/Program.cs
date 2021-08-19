using System;
using System.Collections.Generic;
using System.Linq;

namespace array2d
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < 6; i++)
            {
                var inputData = Console.ReadLine().TrimEnd();
                var listData = inputData.Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
                arr.Add(listData);
                Console.Out.WriteLine(inputData);
            }
            int result = 0;
            if (result >= 90 && result < 100)
            {
                return "T";
            }
            else if (result >= 80 && < 90)
            {
                return "E";
            }
            else if (result >= 70 && < 80)
            {
                return "A";
            }
            else if (result >= 55 && < 70)
            {
                return "P";
            }
            else if (result >= 40 && < 55)
            {
                return "D";
            }
            else if (result < 40)
            {
                return "T";
            }
        }
    }
}
