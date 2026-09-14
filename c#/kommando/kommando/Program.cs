using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kommando
{
    internal class Program
    {
        static int MinDistance(int[] distance, bool[] visited, int nodesCount)
        {
            int min = int.MaxValue;
            int min_index = -1;

            for (int u = 0; u < nodesCount; u++)
            {
                if (visited[u] == false && distance[u] <= min)
                {
                    min = distance[u];
                    min_index = u;
                }
            }
            return min_index;
        }

        static void Dijkstra(int[,] matrix,int startNode, int endNode)
        {
            int nodesCount = matrix.GetLength(0);
            int[] distance = new int[nodesCount];
            bool[] visited = new bool[nodesCount];
            int[] from = new int[nodesCount];

            // 1. lépés: távolságok-> végtelen, meglátogatott-> false
            for (int i = 0; i < nodesCount; i++)
            {
                distance[i] = int.MaxValue;
                visited[i] = false;
            }

            // 2. lépés: Kezdőpont távolsága->0
            distance[startNode] = 0;

            // 3. lépés: ciklus
            for (int i = 0; i < nodesCount; i++)
            {
                // 3. a lépés: Kiválasztjuk a legkisebb távolságú csúcsot
                int u = MinDistance(distance, visited, nodesCount);
                // 3. b lépés: az u csúcsot meglátogatottnak jelöljük
                visited[u] = true;

                // 3. c lépés: frissítjük a szomszédos csúcsok távolságát
                for (int v = 0; v < nodesCount; v++)
                {
                    // Frissítés, ha találtunk egy rövidebb utat
                    if (visited[v] == false &&
                         matrix[u, v] != -1 &&
                         distance[u] != int.MaxValue &&
                         distance[u] + matrix[u, v] < distance[v])
                    {
                        distance[v] = distance[u] + matrix[u, v];
                        from[v] = u;
                    }
                }
            }

            PrintDistances(distance, from, endNode, startNode);
        }
        static void PrintDistances(int[] distance, int[] from, int endNode, int startNode)
        {
            int end = endNode;
            while (from[end] != startNode)
            {
                
            }
            Console.WriteLine($"{startNode + 1} {from[endNode] + 1} {endNode + 1}");
            Console.WriteLine($"{distance[endNode]}");

        }
        static int[,] GenMatrix(int[] colors)
        {
            FileStream fs = new FileStream("kommando.be", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            string[] data = line.Split(' ');
            int countries = int.Parse(data[0]);
            int[,] matrix = new int[countries, countries];
            for (int i = 0; i < countries; i++)
            {
                for (int j = 0; j < countries; j++)
                {
                    matrix[i, j] = -1;
                }
            }
            for (int i = 0; i < countries; i++)
            {
                line = sr.ReadLine();
                data = line.Split(' ');
                for (int j = 1; j < data.Length; j++)
                {
                    if (colors[int.Parse(data[0])-1] == colors[int.Parse(data[j])-1])
                        matrix[int.Parse(data[0]) - 1, int.Parse(data[j]) - 1] = 0;
                    else
                        matrix[int.Parse(data[0]) - 1, int.Parse(data[j]) - 1] = 1;
                }
            }
            sr.Close();
            fs.Close();
            return matrix;
        }
        static int[] Colors()
        {
            FileStream fs = new FileStream("kommando.be", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            string[] data = line.Split(' ');
            int countries = int.Parse(data[0]);
            int[] colors = new int[countries];
            for (int i = 0;i < countries; i++)
            {
                sr.ReadLine();
            }
            for(int i = 0;i<countries; i++)
            {
                line = sr.ReadLine();
                data = line.Split(' ');
                colors[i] = int.Parse(data[0]);
            }
            sr.Close();
            fs.Close();
            return colors;
        }
        static void Main(string[] args)
        {
            int[] colors = Colors();
            int [,] matrix = GenMatrix(colors);
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
            Dijkstra(matrix, 0, 4);
        }
    }
}
