using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphalgs_bfs_dfs
{
    class Graph
    {
        private int V; // number of nodes
        private List<int>[] adj; // Adjacency list

        public Graph(int v)
        {
            V = v;
            adj = new List<int>[v];
            for (int i = 0; i < v; ++i)
                adj[i] = new List<int>();
        }

        /// <summary>
        /// v is the parent, w is the child
        /// </summary>
        /// <param name="p"></param>
        /// <param name="c"></param>
        public void AddEdge(int p, int c)
        {
            adj[p].Add(c);
        }

        // BFS from a given start node
        public void BFS(int s)
        {
            bool[] visited = new bool[V]; // all the nodes are not visited from the beginning

            Queue<int> queue = new Queue<int>(); // create a queue for BFS

            visited[s] = true; // mark the node as visited and add it to the queue
            queue.Enqueue(s);

            while (queue.Count != 0)
            {
                s = queue.Dequeue(); // remove a node from the queue and print it
                Console.Write(s + " ");

                // get all the neigbours to the removed node and - if a neighbour
                // is not visited - mark it as visited and add it to the queue
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

        //DFS from a given start node
        public void DFS(int s)
        {
            bool[] visited = new bool[V]; // all nodes are not visited from the beginning

            Stack<int> stack = new Stack<int>(); // create a stack for DFS

            visited[s] = true; // mark the node as visited and add it to the stack
            stack.Push(s);

            while (stack.Count != 0)
            {
                s = stack.Pop(); // remove a node from the stack and print it
                Console.Write(s + " ");

                // get all the neighbours for the removed node and - if a
                // neigbour is not visited - mar it as visited and add it to the stack
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