using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
//https://algorithms.tutorialhorizon.com/graph-depth-first-search-in-disconnected-graph/
/*
 * Define 
 */
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
            bool[] visited;
            private int Max;

            Graph(int vertices)
            {
                Nodes = vertices;
                Max = vertices + 1;
                adjacencyList = new LinkedList<int>[Max];
                //Initializing adjacency lists with empty lists
                for (int i = 0; i < Max; ++i)
                    adjacencyList[i] = new LinkedList<int>();
            }

            void AddEdge(int source, int destination)
            {
                adjacencyList[source].AddFirst(destination);
                adjacencyList[destination].AddFirst(source);
                /*if (adjacencyList[source].Count == 0)
                {
                    adjacencyList[source] = new LinkedList<int>();
                    adjacencyList[source].AddFirst(destination);
                }
                else
                {
                    var last = adjacencyList[source].Last;
                    adjacencyList[source].AddAfter(last, destination);
                }*/
            }

            public int GetConnectedComponentSize(int position)
            {
                Stack<int> nodesToVisit = new Stack<int>();
                nodesToVisit.Push(position);
                visited[position] = true;
                int cnt = 0;
                Console.WriteLine("Posicao atual" + position);
                while (nodesToVisit.Count>0)
                {                    
                    position = nodesToVisit.Pop();
                    cnt += 1;

                    foreach (var y in adjacencyList[position])
                    {
                        Console.WriteLine("Olhando para a posicao "+position+" a proxima posicao de: " + y);
                        if (!visited[y])
                        {
                            visited[y] = true;
                            nodesToVisit.Push(y);
                        }
                    }
                }
                Console.WriteLine();
                return cnt;
            }

            public int CalcSum()
            {
                visited = new bool[Max];
                int sum = 0;
                int connectedNodes = 0;
                
                foreach (int i in Enumerable.Range(1, Nodes))
                {
                        if (!visited[i])
                        {
                            connectedNodes = GetConnectedComponentSize(i);                            
                            double result = Math.Ceiling(Math.Sqrt(connectedNodes));
                            sum += (connectedNodes > 1 ) ? Convert.ToInt32(result) : 1;
                        }                 
                }                
                return sum;
            }
            public void BfsRecursion()
            {
                bool[] visited = new bool[Nodes];
                ArrayList connectedComponent = new ArrayList();
                //visit from each node if not already visited
                for (int i = 0; i < Nodes; i++)
                {
                    if (!visited[i])
                    {
                        bfs(i, visited, connectedComponent);
                    }
                }
                Console.WriteLine(connectedComponent.ToString());
            }

            public void bfs(int start, bool[] visited, ArrayList connectedComponent)
            {
                visited[start] = true;
                int elements = adjacencyList[start].Count; //elementos de cada lista conectada

                if (elements == 0)
                    return;
                
                connectedComponent.Add(start);

                for (int i = 0; i < elements ; i++)
                {
                    var vertex = adjacencyList[start].Last();
                    connectedComponent.Add(vertex);                    
                    if (!visited[vertex])
                    {
                        adjacencyList[start].RemoveLast();
                        bfs(vertex, visited, connectedComponent);                        
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
                for (int i = 0; i < graphFrom.Count; ++i)
                {
                    //startNode, endNode
                    g.AddEdge(graphFrom[i], graphTo[i]);                    
                }
                return g.CalcSum();                    
            }
         }
    }
}
