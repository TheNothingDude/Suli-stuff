using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace osztaly
{
    internal class Program
    {
        static int[,] CreateMatrix()
        {
            FileStream fs = new FileStream("osztaly.be", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string row = sr.ReadLine();
            string[] data;
            int rowcount = 0;
            int[,] m = new int[int.Parse(row),int.Parse(row)];
            while((row = sr.ReadLine()) != null)
            {
                data = row.Split(' ');
                foreach(string s in data)
                {
                    if(int.Parse(s) !=0)
                    {
                        m[rowcount, int.Parse(s)-1] = 1;
                    }
                }
                rowcount++;

            }
            sr.Close();
            fs.Close(); 
            return m;
        }
        static void Que(ref int[] t, int newItem )
        {
            int[] tmp = new int[t.Length+1];
            for( int i = 0; i <t.Length; i++)
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
                tmp[i-1] = t[i];
            }
            t= tmp;
            return r;
        }
        static int[] BFS(int[,] m, int Start)
        {
            int points = m.GetLength(0);
            int[] row = new int[0];
            int[] tav = new int[points];

            for (int i = 0;i<tav.Length; i++)
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
        static int MaxTav(int[] tav)
        {
            int max = 0;
            foreach(int i in tav)
            {
                if(i > max)
                {
                    max = i;
                }
            }
            return max;
        }

        static void Main(string[] args)
        {
            int[,] m = CreateMatrix();

            for(int i =0;  i < m.GetLength(0); i++)
            {
                for(int j = 0;j< m.GetLength(1); j++)
                {
                    Console.Write(m[i,j]);
                }
                Console.WriteLine();
            }

            int max = 0;
            int person = 0;
            for(int i = 0; i < m.GetLength(0); i++)
            {
                if(MaxTav(BFS(m, i)) > max)
                {
                    max = MaxTav(BFS(m, i));
                    person = i+1;
                }
            }
            FileStream fs = new FileStream("osztaly.ki", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(person);
            sw.Close();
            fs.Close();
        }
    }
}
