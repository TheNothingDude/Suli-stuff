using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dfs
{
    internal class Program
    {
        public static void DFS(int[,] m, int startingNode)
        {
            int totalNodes = m.GetLength(0);
            bool[] visited = new bool[totalNodes];
            Stack stack = new Stack();

            stack.Push(startingNode);
            visited[startingNode] = true;
            while (stack.Count >0)
            { 
                int currentNode = (int)stack.Pop();
                Console.Write($"{currentNode}, ");
                for(int i = totalNodes-1; i >=0; i--)
                {
                    if (m[currentNode,i] == 1 && !visited[i])
                    {
                        stack.Push(i);
                        visited[i] = true;
                    }
                }
            }
        }
        public static void DFSCount(int[,] m, int startingNode)
        {
            int totalNodes = m.GetLength(0);
            bool[] visited = new bool[totalNodes];
            Stack stack = new Stack();

            stack.Push(startingNode);
            visited[startingNode] = true;
            int be = 1;
            int ki = 1;
            
            while (stack.Count > 0)
            {
                int currentNode = (int)stack.Pop();
                be++;
                bool noNeighbor = true;
                Console.Write($"{currentNode}: be:{be} ki:{ki}, ");
                for (int i = totalNodes - 1; i >= 0; i--)
                {
                    if(m[currentNode, i] == 1 && !visited[i])
                    {
                        stack.Push(i);
                        visited[i] = true;
                        noNeighbor = false;
                
                    }
                }
                if(noNeighbor)
                {
                    ki++;
                }
            }

        }

        static void Main(string[] args)
        {
            int[,] m = new int[7, 7]
            {
                {0, 1, 1, 0, 0, 0, 0 },
                {0, 0, 0, 1, 0, 0, 0 },
                {0, 0, 0, 0, 1, 1, 0 },
                {0, 0, 0, 0, 1, 0, 0 }, 
                {0, 0, 0, 0, 0, 0, 1 },
                {0, 0, 0, 0, 1, 0, 1 },
                {0, 0, 0, 0, 0, 0, 0 }
            };

            DFSCount(m, 0);
        }
    }
}
