using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphalgs_bfs_dfs
{
    class Graph
    {
        private int V; // Antal noder
        private List<int>[] adj; // Adjacencylista

        public Graph(int v)
        {
            V = v;
            adj = new List<int>[v];
            for (int i = 0; i < v; ++i)
                adj[i] = new List<int>();
        }

        public void AddEdge(int v, int w)
        {
            adj[v].Add(w); // Lägg till w till v's lista.
        }

        // BFS från en given startnod
        public void BFS(int s)
        {
            bool[] visited = new bool[V]; // Alla noder är inte besökta i början

            Queue<int> queue = new Queue<int>(); // Skapa en kö för BFS

            visited[s] = true; // Markera aktuell nod som besökt och lägg till den i kön
            queue.Enqueue(s);

            while (queue.Count != 0)
            {
                s = queue.Dequeue(); // Ta bort en nod från kön och skriv ut den
                Console.Write(s + " ");

                // Hämta alla grannar till den borttagna noden och om en granne inte är besökt, markera den som besökt och lägg till den i kön
                foreach (int next in adj[s])
                {
                    if (!visited[next])
                    {
                        visited[next] = true;
                        queue.Enqueue(next);
                    }
                }
            }
        }

        // DFS från en given startnod
        public void DFS(int s)
        {
            bool[] visited = new bool[V]; // Alla noder är inte besökta i början

            Stack<int> stack = new Stack<int>(); // Skapa en stack för DFS

            visited[s] = true; // Markera aktuell nod som besökt och lägg till den i stacken
            stack.Push(s);

            while (stack.Count != 0)
            {
                s = stack.Pop(); // Ta bort en nod från stacken och skriv ut den
                Console.Write(s + " ");

                // Hämta alla grannar till den borttagna noden och om en granne inte är besökt, markera den som besökt och lägg till den i stacken
                foreach (int next in adj[s])
                {
                    if (!visited[next])
                    {
                        visited[next] = true;
                        stack.Push(next);
                    }
                }
            }
        }
    }
}