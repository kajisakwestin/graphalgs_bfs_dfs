// See https://aka.ms/new-console-template for more information
using graphalgs_bfs_dfs;

int numberOfNodes = 7;
Graph g = new Graph(numberOfNodes);
int startNode;

g.AddEdge(0, 1);
g.AddEdge(0, 2);
g.AddEdge(1, 3);
g.AddEdge(1, 4);
g.AddEdge(2, 5);
g.AddEdge(2, 6);
g.AddEdge(3, 3);
g.AddEdge(4, 4);
g.AddEdge(5, 5);
g.AddEdge(6, 6);

//ta emot ett värde att använda som startnod
Console.WriteLine("Ange startnod:");
startNode = int.Parse(Console.ReadLine());

//så länge inte startNode är negativt eller större än antalet noder, fortsätt fråga efter startnod
while (startNode >= 0 && !(startNode > numberOfNodes - 1))
{
    Console.WriteLine($"BFS från nod {startNode}:");
    g.BFS(startNode);
    Console.WriteLine($"\nDFS från nod {startNode}:");
    g.DFS(startNode);

    Console.WriteLine("\n\nAnge en ny startnod:");
    startNode = int.Parse(Console.ReadLine());
}

//avsluta programmet
Console.WriteLine("The End");
Console.ReadLine();