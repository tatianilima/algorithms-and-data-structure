using System;
using System.Collections.Generic;

namespace connected_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var textWriter = "";

            string[] graphNodesEdges = Console.ReadLine().TrimEnd().Split(' ');

            int graphNodes = Convert.ToInt32(graphNodesEdges[0]);
            int graphEdges = Convert.ToInt32(graphNodesEdges[1]);

            List<int> graphFrom = new List<int>();
            List<int> graphTo = new List<int>();

            for (int i = 0; i < graphEdges; i++)
            {
                string[] graphFromTo = Console.ReadLine().TrimEnd().Split(' ');

                graphFrom.Add(Convert.ToInt32(graphFromTo[0]));
                graphTo.Add(Convert.ToInt32(graphFromTo[1]));
            }

            int result = Result.connectedSum(graphNodes, graphFrom, graphTo);

            Console.WriteLine(result);
        }
    }
}
