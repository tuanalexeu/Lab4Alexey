using System;

namespace Lab4Alexey {
    class Program {
        static void Main(string[] args) {
            // Deep-First Search algorithm
            Graph g = new Graph(4);
 
            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(1, 2);
            g.AddEdge(2, 0);
            g.AddEdge(2, 3);
            g.AddEdge(3, 3);
 
            Console.WriteLine(
                "Following is Depth First Traversal "
                + "(starting from vertex 2)");
 
            g.DFS_method(2);
            Console.ReadKey();
            
            // Breadth-First Search algorithm
            Graph g2 = new Graph(4);
     
            g2.AddEdge(0, 1);
            g2.AddEdge(0, 2);
            g2.AddEdge(1, 2);
            g2.AddEdge(2, 0);
            g2.AddEdge(2, 3);
            g2.AddEdge(3, 3);
     
            Console.Write("Following is Breadth First " +
                          "Traversal(starting from " +
                          "vertex 2)\n");
            g2.BFS_method(2);
            
            
            
            
        }
    }
}