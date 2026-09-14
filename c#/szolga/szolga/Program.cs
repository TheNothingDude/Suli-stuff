using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace szolga
{
    internal class Program
    {
        static int[,] CreateMatrix()
        {
            FileStream fs = new FileStream("szolga.be" , FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string row;
            string[] data;
            row = sr.ReadLine();
            data = row.Split(' ');
            int[,] r = new int[int.Parse(data[0]),int.Parse(data[0])];
            row = sr.ReadLine();
            int rowcount = 0;
            while ((row = sr.ReadLine()) != null)
            {
                data = row.Split(' ');
                foreach (string s in data)
                {
                    if(int.Parse(s) != 0)
                    {
                        r[rowcount, int.Parse(s)-1] = 1;
                    }
                }
                rowcount++;
            }
            sr.Close();
            fs.Close();
            return r;
        }
        static void Que(ref int[] t, int newItem)
        {
            int[] tmp = new int[t.Length + 1];
            for (int i = 0; i < t.Length; i++)
            {
                tmp[i] = t[i];
            }
            tmp[t.Length] = newItem;
            t = tmp;
        }

        static int Deque(ref int[] t)
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
        static int[] Kiszonlg()
        {
            FileStream fs = new FileStream("szolga.be", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string row;
            string[] data;
            row = sr.ReadLine();
            data = row.Split(' ');
            int[] r = new int[int.Parse(data[1])];
            row = sr.ReadLine();
            data= row.Split(' ');
            foreach(string s in data)
            {
                Que(ref r, int.Parse(s)-1);
            }
            sr.Close();
            fs.Close();
            return r;
        }

        static int[] BFS(int[,] m, int Start)
        {
            int points = m.GetLength(0);
            int[] row = new int[0];
            int[] tav = new int[points];
            for (int i = 0; i < tav.Length; i++)
            {
                tav[i] = -1;
            }
                tav[Start] = 0;
                Que(ref row, Start);

                while (row.Length > 0)
                {
                    int removed = Deque(ref row);
                    for (int i = 0; i < points; i++)
                    {
                        if (m[removed, i] == 1 && tav[i] == -1)
                        {
                            Que(ref row, i);
                            tav[i] = tav[removed] + 1;
                        }
                    }
                }
            return tav;
        }

        static void Main(string[] args)
        {
            int[,] m = CreateMatrix();
            FileStream fs = new FileStream("szolga.ki", FileMode.Create);
            StreamWriter wr = new StreamWriter(fs);
            int[,] lenghts = new int[Kiszonlg().Length, m.GetLength(0)];
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for(int j = 0; j< m.GetLength(1); j++)
                {
                    Console.Write(m[i,j]);
                }
                Console.WriteLine();
            }
            foreach (int i in Kiszonlg())
            {
                int[] tav = BFS(m, i);
                for(int j = 0; j < lenghts.GetLength(0); j++)
                {
                    for(int k = 0; k < tav.Length; k++)
                    {
                        lenghts[j,k] = tav[k];
                    }
                }
            }
            int max = 0;
            foreach(int i in Kiszonlg())
            {
                foreach(int j in BFS(m, i))
                {
                    if(j> max)
                    {
                        max = j;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < lenghts.GetLength(0); i++)
            {
                for (int j = 0; j < lenghts.GetLength(1); j++)
                {
                    Console.Write(lenghts[i, j]);
                }
                Console.WriteLine();
            }
            wr.Write(max);
            wr.Close();
            fs.Close();

        }
    }
}
