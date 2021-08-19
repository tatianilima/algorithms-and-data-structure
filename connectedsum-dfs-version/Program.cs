using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
//https://algorithms.tutorialhorizon.com/graph-depth-first-search-in-disconnected-graph/

namespace connectedsum
{
    class Program
    {
        static void Main(string[] args)
        {
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

            int result = Graph.ConnectedSum(graphNodes, graphEdges, graphFrom, graphTo);

            Console.WriteLine(result);
        }

        class Graph
        {
            private int Nodes; // No. of vertices(nodes)            
            private LinkedList<int>[] adjacencyList;// Adjacency List Representation
            private Queue<int> NodesToVisit = new Queue<int>();
            private int count = 0;

            Graph(int vertices)
            {
                Nodes = vertices + 1;
                adjacencyList = new LinkedList<int>[vertices + 1];
                //Initializing adjacency lists with empty lists
                for (int i = 0; i <= vertices; ++i)
                    adjacencyList[i] = new LinkedList<int>();
            }

            void AddEdge(int source, int destination)
            {
                adjacencyList[source].AddFirst(destination);
            }

            public void DFSRecursion()
            {
                ArrayList abc = new ArrayList();
                bool[] visited = new bool[Nodes];                
                //visit from each node if not already visited
                for (int i = 0; i < Nodes; i++)
                {
                    if (!visited[i])
                    {
                        dfs(i, visited);
                    }
                }
            }

            public void dfs(int start, bool[] visited)
            {
                visited[start] = true;
                //Console.Write(start + " ");
                int elements = adjacencyList[start].Count; //elementos de cada lista conectada

                if (elements == 0)
                {
                    return;
                }

                ArrayList abc = new ArrayList();
                abc.Add(start);
                for (int i = 0; i < elements ; i++)
                {
                    var vertex = adjacencyList[start].First();
                    abc.Add(vertex);                    
                    if (!visited[vertex])
                    {
                        dfs(vertex, visited);                        
                    }              
                }
            }

            //Print the graph
            public void PrintAdjacencyList()
            {
                int i = 0;
                foreach (LinkedList<int> item in adjacencyList)
                {
                    if (item != null && item.Count > 0)
                    {
                        Console.Write("adjacencyList[" + i + "]-> ");
                    }
                    foreach (int edge in item)
                    {
                        Console.Write(edge + " ");
                    }
                    ++i;                   
                }
            }
            


            public static int ConnectedSum(int graphNodes, int graphEdges, List<int> graphFrom, List<int> graphTo)
            {
                Graph g = new Graph(graphNodes);                

                //formar os pares e armazenar numa lista
                for (int i = 0; i < graphEdges; ++i)
                {
                    //startNode, endNode
                    g.AddEdge(graphFrom[i], graphTo[i]);                    
                }
                
                g.DFSRecursion();
                Console.WriteLine("=============");
                int sum = 0;
                /*
                foreach (var item in g.sumList)
                {
                    double raizquadrada = Math.Sqrt(item);
                    double answer = Math.Ceiling(raizquadrada);
                    sum += Convert.ToInt32(answer);
                }
                */
                Console.WriteLine(sum);
                Console.WriteLine("=============");

                //g.PrintAdjacencyList();

                return sum;                    
            }
         }
    }
}
