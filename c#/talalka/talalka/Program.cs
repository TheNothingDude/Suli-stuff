using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace talalka
{
    internal class Program
    {
        static void Add(ref int[] t, int newItem)
        {
            int[] tmp = new int[t.Length + 1];
            for (int i = 0; i < t.Length; i++)
            {
                tmp[i] = t[i];
            }
            tmp[t.Length] = newItem;
            t = tmp;
        }
        static int[,] CreateMatrix()
        {
            FileStream fs = new FileStream("talalka.be", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            string[] data = line.Split(' ');
            int[,] m = new int[int.Parse(data[0]), int.Parse(data[0])];
            while ((line = sr.ReadLine()) != null)
            {
                data = line.Split(' ');
                m[int.Parse(data[0]) - 1, int.Parse(data[1]) - 1] = 1;
            }
            sr.Close();
            fs.Close();
            return m;

        }
        static int[] StartingPoints()
        {
            int[] r = new int[0];
            FileStream fs = new FileStream("talalka.be", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string[] data = sr.ReadLine().Split(' ');
            Add(ref r, int.Parse(data[1]) - 1);
            Add(ref r, int.Parse(data[2]) - 1);
            sr.Close();
            fs.Close();
            return r;
        }
        static int[] DFS(int[,] matrix, int startingPoint)
        {
            Stack stack = new Stack();
            int[] steps = new int[0];
            bool[] visited = new bool[matrix.GetLength(0)];
            visited[startingPoint] = true;
            stack.Push(startingPoint);
            while (stack.Count > 0)
            {
                int current = (int)stack.Pop();
                Add(ref steps, current+1);
                for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
                {
                    if (matrix[current, i] == 1 && !visited[i])
                    {
                        visited[i] = true;
                        stack.Push(i);
                    }
                }
            }
            return steps;
        }

        static void Main(string[] args)
        {
            int[,] matrix = CreateMatrix();
            int[] eva = DFS(matrix, StartingPoints()[0]);
            int[] adam = DFS(matrix, StartingPoints()[1]);
            int tali = 0;
            bool talalt = false;
            for(int i = 0; i < eva.Length && !talalt;i++)
            {
                for(int j = 0;j<adam.Length;j++)
                {
                    if(adam[j] == eva[i])
                    {
                        tali = adam[j];
                        talalt = true;
                    }
                }
            }
            foreach (int i in adam)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            foreach (int i in eva)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine(tali);
            //for (int i = 0; i < eva.Length && eva[i] != tali ; i++)
            //{
            //    Console.Write($"{eva[i]}");
            //}
        }
    }
}
