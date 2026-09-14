using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace bfs
{
    internal class Program
    {
        static void Queue(ref int[] t, int newItem)
        {
            int[] tmp = new int[t.Length + 1];
            for (int i = 0; i < t.Length; i++)
            {
                tmp[i] = t[i];
            }
            tmp[t.Length] = newItem;
            t = tmp;
        }

        static int Dequeue(ref int[] t)
        {
            int r = t[0];
            int[] tmp = new int[t.Length - 1];
            for (int i = 1; i < t.Length; i++)
            {
                tmp[i - 1] = t[i];
            }
            t = tmp;

            return r;
        }

        static void BFS(int[,] m, int startingPoint)
        {
            int points = m.GetLength(0);
            int[] row = new int[0];
            bool[] visited = new bool[points];
            //1
            Console.WriteLine("Bfs order: ");
            visited[startingPoint] = true;
            Queue(ref row, startingPoint);
            //2
            while (row.Length > 0)
            {
                int removed = Dequeue(ref row);
                Console.Write($"{removed},");
                for (int i = 0; i < points; i++)
                {
                    if (m[removed, i] == 1 && !visited[i])
                    {
                        Queue(ref row, i);
                        visited[i] = true;
                    }
                }
            }


        }
        static void BFSTav(int[,] m, int startingPoint)
        {
            int points = m.GetLength(0);
            int[] row = new int[0];
            int[] tav = new int[points];
            
            for(int i =0; i<tav.Length; i++)
            {
                tav[i] = -1;
            }
            //1
            Console.WriteLine("Bfs order: ");
            tav[startingPoint] = 0;
            Queue(ref row, startingPoint);
            //2
            while (row.Length > 0)
            {
                int removed = Dequeue(ref row);
                Console.Write($"{removed},");
                for (int i = 0; i < points; i++)
                {
                    if (m[removed, i] == 1 && tav[i] == -1)
                    {
                        Queue(ref row, i);
                        tav[i] = tav[removed] + 1;
                    }
                }
            }
            Console.WriteLine($"Tavolsagok a {startingPoint}-tol: ");
            for(int i=0; i< tav.Length; i++)
            {
                Console.Write($"{i}. csucs: ");
                if(tav[i] == -1)
                {
                    Console.WriteLine("Elerhetetlen csucs");
                }
                else
                {
                    Console.WriteLine(tav[i]);
                }
            }

        }

        static void Main(string[] args)
        {
            int[,] m = new int[5, 5]
            {
                { 0, 1, 1, 0, 0 },
                { 1, 0, 0, 1, 1 },
                { 1, 0, 0, 0, 0 },
                { 0, 1, 0, 0, 0 },
                { 0, 1, 0, 0, 0 },

            };
            int[,] m2 = new int[8, 8]
            {
                {0,0,0,1,0,0,0,1},
                {0,0,0,0,0,0,0,1},
                {0,0,0,0,0,0,0,0},
                {1,0,1,0,1,0,0,0},
                {0,0,0,1,0,0,0,0},
                {0,0,0,0,1,0,0,1},
                {0,0,0,0,0,0,0,0},
                {1,1,0,0,0,1,0,0}
            };
            //BFS(m2, 5);
            BFSTav(m2, 0);
        }
    }
}
