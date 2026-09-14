using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dijkstra
{
    internal class Program
    {
        static int MinDistance(int[] distance, bool[] visited, int nodes)
        {
            int min = int.MaxValue;
            int min_index = -1;
            for(int u = 0; u < nodes; u++)
            {
                if (visited[u] == false && distance[u] <= min)
                {
                    min = distance[u];
                    min_index = u;
                }
            }
            return min_index;
        }
        static void Dijk(int[,] m,int startingNode)
        {
            int nodes = m.GetLength(0);
            int[] distance = new int[nodes];
            bool[] visited = new bool[nodes];
            int[] from = new int[nodes];

            //1. step
            for (int i = 0; i < nodes; i++)
            {
                distance[i] = int.MaxValue;
                visited[i] = false;
            }
            distance[startingNode] = 0;
            //2
            for (int i = 0;i < nodes; i++)
            {
                int u = MinDistance(distance ,visited, nodes);
                visited[u] = true;

                for(int v =0; v < nodes; v++) 
                {
                    if (!visited[v] && m[u,v] != 0 && distance[u] != int.MaxValue && distance[u] + m[u, v] < distance[v])
                    {
                        distance[v] = distance[u] + m[u,v];
                        from[v] = u;

                    }

                }
            }
            //PrintDistances(distance, startingNode);
            PrintDistances(distance,from, startingNode);
        }
        static void PrintDistances(int[] distances, int[] from, int startNode)
        {
            Console.WriteLine($"{startNode}-tol tavolsag: ");
            for (int i = 0; i < distances.Length; i++)
            {
                Console.WriteLine($"{i}. csucs, tavolsaga: {distances[i]}");
            }
            for(int i = 0;i<from.Length; i++)
            {
                Console.WriteLine($"{i}. csucs a {from[i]}-bol");
            }
        }
        static void Main(string[] args)
        {
            int[,] m = { 
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
            Dijk(m, 0);
        }
    }
}
