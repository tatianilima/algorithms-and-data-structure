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
        }
    }
}
