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
                "Поиск в глубину:");
 
            g.DFS_method(2);
            
            // Breadth-First Search algorithm
            Graph g2 = new Graph(4);
     
            g2.AddEdge(0, 1);
            g2.AddEdge(0, 2);
            g2.AddEdge(1, 2);
            g2.AddEdge(2, 0);
            g2.AddEdge(2, 3);
            g2.AddEdge(3, 3);
     
            Console.Write("Поиск в ширину:\n");
            g2.BFS_method(2);

            Console.WriteLine("Алгоритм Крускала:");
            // Kruskal's algorithm
            int verticesCount = 4;
            int edgesCount = 5;
            KruskalAlgorithm.Graph graph = KruskalAlgorithm.CreateGraph(verticesCount, edgesCount);

            // Edge 0-1
            graph.edge[0].Source = 0;
            graph.edge[0].Destination = 1;
            graph.edge[0].Weight = 10;

            // Edge 0-2
            graph.edge[1].Source = 0;
            graph.edge[1].Destination = 2;
            graph.edge[1].Weight = 6;

            // Edge 0-3
            graph.edge[2].Source = 0;
            graph.edge[2].Destination = 3;
            graph.edge[2].Weight = 5;

            // Edge 1-3
            graph.edge[3].Source = 1;
            graph.edge[3].Destination = 3;
            graph.edge[3].Weight = 15;

            // Edge 2-3
            graph.edge[4].Source = 2;
            graph.edge[4].Destination = 3;
            graph.edge[4].Weight = 4;

            KruskalAlgorithm.Kruskal(graph);
            
            // Dijkstra's algorithm
            Console.WriteLine("Алгоритм Дейкстры:");
            int[, ] graph1 = new int[, ] { 
                { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
                { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
                { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
                { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
                { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
                { 0, 0, 4, 14, 10, 0, 2, 0, 0 },
                { 0, 0, 0, 0, 0, 2, 0, 1, 6 },
                { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
                { 0, 0, 2, 0, 0, 0, 6, 7, 0 } 
            };
            GFG t = new GFG();
            t.dijkstra(graph1, 0);
        }
    }
}