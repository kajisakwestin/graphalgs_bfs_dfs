// See https://aka.ms/new-console-template for more information
using graphalgs_bfs_dfs;

Console.WriteLine("Hello, World!");

Graph g = new Graph(4);

g.AddEdge(0, 1);
g.AddEdge(0, 2);
g.AddEdge(1, 2);
g.AddEdge(2, 0);
g.AddEdge(2, 3);
g.AddEdge(3, 3);

Console.WriteLine("BFS från nod 2:");
g.BFS(2);
Console.WriteLine("\nDFS från nod 2:");
g.DFS(2);

Console.ReadLine();