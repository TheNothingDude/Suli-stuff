using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;



namespace MyApp
{
    internal class Program
    {
        static int[,] MatrixLetrehoz()
        {
            FileStream fs= new FileStream("szallitas.be", FileMode.Open);
            StreamReader sr= new StreamReader(fs);
            string sor = sr.ReadLine();
            string[] data = sor.Split(' ');
            int[,] m = new int[int.Parse(data[0]),int.Parse(data[0])];

            while((sor = sr.ReadLine()) != null)
            {
                data = sor.Split(' ');
                m[int.Parse(data[0])-1,int.Parse(data[1])-1] = 1;
            }
            sr.Close();
            fs.Close();
            return m;
        }
        static int OszlopCount(int[,] m, int oszlop)
        {
            int c=0;
            for(int i =0;i<m.GetLength(0);i++)
            {
                if(m[i,oszlop]==1)
                {
                    c++;
                }
            }
            return c;
        }
        static int SorCount(int[,] m, int sor)
        {
            int c =0;
            for(int j=0; j<m.GetLength(1); j++)
            {
                if(m[sor,j]==1)
                {
                    c++;
                }
            }
            return c;
        }
        static void Add(ref int[] t, int n)
        {
            int[] tmp = new int[t.Length+1];
            for(int i =0;i<t.Length;i++)
            {
                tmp[i] = t[i];
            }
            tmp[t.Length] = n;
            t = tmp;
        }
        static int[] Termelok(int[,] m)
        {
            int[] term = new int[0];
            for(int j=0; j<m.GetLength(1);j++)
            {
                if(OszlopCount(m,j)==0)
                {   
                    Add(ref term, j+1);
                }
            }
            return term;
        }
        static int[] Eladok(int[,] m)
        {
            int[] term = new int[0];
            for(int j=0; j<m.GetLength(1);j++)
            {
                if(SorCount(m,j)==0)
                {   
                    Add(ref term, j+1);
                }
            }
            return term;
        }
        static int[] CsakTermeloktol(int[,] m)
        {
            int[] r = new int[0];
            foreach(int i in Termelok(m))
            {
                for(int j =0; j<m.GetLength(0);j++)
                {
                    if(m[i-1,j] ==1)
                    {
                        foreach(int n in Eladok(m))
                        {
                            if(j==n-1)
                            {
                                Add(ref r, j+1);
                            }
                        }
                    }
                }
            }
            return r;
        }
        static int[] NincsKapcs(int[,] m)
        {
            int[] r = new int[0];

            foreach(int i in Termelok(m))
            {
                for(int j=0; j<m.GetLength(0);j++)
                {
                    if(m[i-1,j] !=1)
                    {
                        foreach(int n in Eladok(m))
                        {
                            if(m[j,n-1]!=1)
                            {
                                Add(ref r, j+1);
                            }
                        }
                    }
                }
            }
            return r;
        }
        static void Main(string[] args)
        {
            int[,] m = MatrixLetrehoz();
            for(int i =0; i<m.GetLength(0);i++)
            {
                for(int j=0; j<m.GetLength(1);j++)
                {
                    System.Console.Write($"{m[i,j]} ");
                }
                System.Console.WriteLine();
            }

            foreach(int i in Termelok(m))
            {
                System.Console.WriteLine(i);
            }
            System.Console.WriteLine();
            foreach(int i in Eladok(m))
            {
                System.Console.WriteLine(i);
            }
            System.Console.WriteLine();
            foreach(int i in CsakTermeloktol(m))
            {
                System.Console.WriteLine(i);
            }
            foreach(int i in NincsKapcs(m))
            {
                System.Console.WriteLine(i);
            }
        }
    }
}