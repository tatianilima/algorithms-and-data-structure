using System;
using System.Collections;
using System.Collections.Generic;
//https://algorithms.tutorialhorizon.com/graph-depth-first-search-in-disconnected-graph/

namespace connectedsum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] test = new[] { "" };
            string[] firstTest = new[] { "1 2", "1 3", "2 4", "3 5", "7 8" };
            string[] secondTest = new[] { "1 2", "1 4" };
            string[] thirdTest = { };
            string[] fourthTest = { };
            Console.WriteLine();

            int firstResult = Graph.ConnectedSum(10, firstTest);
            Console.WriteLine(firstResult);

            int secondResult = Graph.ConnectedSum(4, secondTest);
            Console.WriteLine(secondResult);

            int thirdResult = Graph.ConnectedSum(1, thirdTest);
            Console.WriteLine(thirdResult);

            int fourthResult = Graph.ConnectedSum(0, fourthTest);
            Console.WriteLine(fourthResult);
        }

        class Graph
        {
            private LinkedList<int>[] adjacencyList;
            private List<int> visited = new List<int>();
            private int connectedSum = 0;

            public Graph(int nodes)
            {
                // Initializing adjacency lists with empty lists                 
                adjacencyList = new LinkedList<int>[nodes+1];
                for (int i = 0; i < nodes+1; i++)
                {
                    adjacencyList[i] = new LinkedList<int>();
                }
            }

            public static int ConnectedSum(int nodes, string[] edges)
            {
                Graph g = new Graph(nodes);
                for (int i = 0; i < edges.Length; i++)
                {
                    int sourceNode, destinationNode;
                    string[] parts = edges[i].Split(" ");
                    sourceNode = Convert.ToInt32(parts[0]);
                    destinationNode = Convert.ToInt32(parts[1]);

                    //Add Edge on graph here
                    // adding edge: a -> b
                    g.AddEdge(sourceNode, destinationNode);
                }
                Console.WriteLine(g.ToString());
                return 0;
            }

             void AddEdge(int sourceNode, int destinationNode)
             {
                adjacencyList[sourceNode].AddLast(destinationNode);
             }

            void GetGroup(int currentNode)
            {
                if (!visited.Contains(currentNode))
                {
                    visited.Add(currentNode);
                }

            }
        }
    }
}
