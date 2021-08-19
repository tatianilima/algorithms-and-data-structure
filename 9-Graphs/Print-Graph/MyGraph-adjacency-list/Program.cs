using System;
using System.Collections.Generic;
/*
 * Create a new Graph
 */
namespace MyGraph_adjacency_list
{
    class Program
    {
        static void Main(string[] args)
        {
            TestGraph.Print();
        }
        class Graph
        {
            LinkedList<Tuple<int, int>>[] adjacencyList;

            public Graph(int nodes)
            {
                adjacencyList = new LinkedList<Tuple<int, int>>[nodes];
                for (int i = 0; i < adjacencyList.Length; ++i)
                {
                    adjacencyList[i] = new LinkedList<Tuple<int, int>>();
                }
            }

            //Append new Edge to the linked list
            public void AddEdgeAtEnd(int startNode, int endNode, int weight)
            {
                adjacencyList[startNode].AddLast(new Tuple<int, int>(endNode, weight));
            }

            //Print the graph
            public void PrintAdjacencyList()
            {
                int i = 0;
                foreach (LinkedList<Tuple<int, int>> item in adjacencyList)
                {
                    Console.Write("adjacencyList[" + i + "]-> ");
                    foreach (Tuple<int, int> edge in item)
                    {
                        Console.Write(edge.Item1 + "(" + edge.Item2 + ")");
                    }
                    ++i;
                    Console.WriteLine();
                }
            }
        }

        public static class TestGraph
        {
            public static void Print()
            {
                //enter with number of nodes
                int nodes = 4;

                //enter with number of edges
                int edges = 6;

                //create a graph with nodes amount
                Graph myGraph = new Graph(nodes);

                //define variables to startNode, endNode and Weight
                int startNode, endNode, weight;

                //Loop into the edges to add node before or after them
                for (int i = 0; i < edges; ++i)
                {
                    string[] input = Console.ReadLine().Split(' ');

                    startNode = Int32.Parse(input[0]);
                    endNode = Int32.Parse(input[1]);
                    weight = Int32.Parse(input[2]);

                    myGraph.AddEdgeAtEnd(startNode, endNode, weight);
                }

                myGraph.PrintAdjacencyList();
            }
        }
    }
}
