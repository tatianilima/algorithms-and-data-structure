using System;
using System.Collections.Generic;

namespace disconnected_graph_dfirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph.Test();
        }
    }

    public class Graph
    {
        private int V; // No. of vertices

        // Array of lists for
        // Adjacency List Representation
        private List<int>[] adj;

        // Constructor
        Graph(int v)
        {
            V = v;
            adj = new List<int>[v];
            for (int i = 0; i < v; ++i)
                adj[i] = new List<int>();
        }

        // Function to add an edge into the graph
        void addEdge(int v, int w)
        {
            adj[v].Add(w); // Add w to v's list.
        }

        // A function used by DFS
        void DFSUtil(int v, bool[] visited)
        {
            // Mark the current
            // node as visited and print it
            visited[v] = true;
            Console.Write(v + " ");

            // Recur for all the
            // vertices adjacent to this
            // vertex
            foreach (int i in adj[v])
            {
                int n = i;
                if (!visited[n])
                    DFSUtil(n, visited);
            }
        }

        // The function to do
        // DFS traversal. It uses recursive
        // DFSUtil()
        void DFS()
        {
            // Mark all the vertices as not visited(set as
            // false by default in java)
            bool[] visited = new bool[V];

            // Call the recursive helper
            // function to print DFS
            // traversal starting from
            // all vertices one by one
            for (int i = 0; i < V; ++i)
                if (visited[i] == false)
                    DFSUtil(i, visited);
        }

        // Driver code
        public static void Test()
        {
            Graph g = new Graph(9);

            g.addEdge(8, 1);
            g.addEdge(5, 8);
            g.addEdge(7, 3);
            g.addEdge(8, 6);

            Console.WriteLine(
                "Following is Depth First Traversal");

            g.DFS();
        }
    }
}
