using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab4Alexey {
    public class Graph {
        private int V; // No. of vertices
 
        // Array of lists for
        // Adjacency List Representation
        private List<int>[] adj;
 
        // Constructor
        public Graph(int v)
        {
            V = v;
            adj = new List<int>[ v ];
            for (int i = 0; i < v; ++i)
                adj[i] = new List<int>();
        }
 
        // Function to Add an edge into the graph
        public void AddEdge(int v, int w)
        {
            adj[v].Add(w); // Add w to v's list.
        }
 
        // A function used by DFS
        void DFSUtil(int v, bool[] visited)
        {
            // Mark the current node as visited
            // and print it
            visited[v] = true;
            Console.Write(v + " ");
 
            // Recur for all the vertices
            // adjacent to this vertex
            List<int> vList = adj[v];
            foreach(var n in vList)
            {
                if (!visited[n])
                    DFSUtil(n, visited);
            }
        }
 
        // The function to do DFS traversal.
        // It uses recursive DFSUtil()
        public void DFS_method(int v)
        {
            // Mark all the vertices as not visited
            // (set as false by default in c#)
            bool[] visited = new bool[V];
 
            // Call the recursive helper function
            // to print DFS traversal
            DFSUtil(v, visited);
        }
        
        public void BFS_method(int s) {

            // Mark all the vertices as not
            // visited(By default set as false)
            bool[] visited = new bool[V];
            for (int i = 0; i < V; i++)
                visited[i] = false;

            // Create a queue for BFS
            LinkedList<int> queue = new LinkedList<int>();

            // Mark the current node as
            // visited and enqueue it
            visited[s] = true;
            queue.AddLast(s);

            while (queue.Any()) {

                // Dequeue a vertex from queue
                // and print it
                s = queue.First();
                Console.Write(s + " ");
                queue.RemoveFirst();

                // Get all adjacent vertices of the
                // dequeued vertex s. If a adjacent
                // has not been visited, then mark it
                // visited and enqueue it
                List<int> list = adj[s];

                foreach (var val in list) {
                    if (!visited[val]) {
                        visited[val] = true;
                        queue.AddLast(val);
                    }
                }
            }
        }
    }
}