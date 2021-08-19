using System;
using System.Collections;
using System.Collections.Generic;
/*
* https://www.geeksforgeeks.org/connected-components-in-an-undirected-graph/
* Given an undirected graph, print all connected components line by line. For example consider the following graph.
*/
namespace ConnectedComponent
{
    class Program
    {
        static void Main(string[] args)
        {
            TestGraph.Test();
        }
    }

    class Graph
    {
        LinkedList<int>[] adjacencyList;
        public Graph(int nodes)
        {
            adjacencyList = new LinkedList<int>[nodes];
            for (int i = 0; i < adjacencyList.Length ; i++)
            {
                adjacencyList[i] = new LinkedList<int>();
            }
        }

        public void AddEdge(int startNode, int endNode)
        {
            adjacencyList[startNode].AddLast(endNode);
        }

        public void NumberOfConnectedComponents(int nodes)
        {
            //variable to count connected component in given graph
            int count = 0;

            //Dictionary to keep track of visited nodes
            Dictionary<int, bool> visited = new Dictionary<int, bool>();
            
            //start all as false
            for (int i = 0; i < nodes; i++)
            {
                visited[i] = false;
            }

            for (int i = 0; i < nodes; i++)
            {
                if(visited[i] == false)
                {
                    DfsUtil(i, visited);
                    count++;
                    Console.WriteLine();
                }
            }
        }

        public void DfsUtil(int current, Dictionary<int, bool> visited)
        {
            visited[current] = true;
            Console.Write(current + " ");
            foreach (var item in adjacencyList)
            {
                foreach (int edge in item)
                {
                    if (!visited[edge])
                    {
                        DfsUtil(edge, visited);
                    }
                }
            }
        }
    }

    public static class TestGraph
    {
        public static void Test()
        {
            //enter number of nodes
            int nodes = 5;

            //create a graph with nodes amount
            Graph myGraph = new Graph(nodes);
            myGraph.AddEdge(1, 0);
            myGraph.AddEdge(2, 3);
            myGraph.AddEdge(3, 4);

            myGraph.NumberOfConnectedComponents(nodes);
        }
    }
}
